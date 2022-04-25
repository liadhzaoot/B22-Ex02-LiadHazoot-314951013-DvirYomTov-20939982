using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal partial class MainPageForm : Form
    {

        private delegate void ChangeMyButtonDelegate(Control i_Ctrl, string i_Text, System.Drawing.Color i_Color, bool i_Enable);

        private readonly int r_MaximumNumberOfFriendsToShow = 10;
        private readonly int r_MaximumNumberOfPostsToShow = 15;
        private readonly int r_MaximumNumberOfEventsToShow = 15;

        internal delegate void LinkEventHandler();

        internal event LinkEventHandler ProfileLinkClicked;

        internal event LinkEventHandler ZodiacLinkClicked;

        internal event LinkEventHandler LogoutButtonClicked;

        private List<Post> m_Posts;
        private List<User> m_Friends;
        private List<User> m_Matches;
        private List<Event> m_Events;

        private User m_LoggedInUser;

        public MainPageForm()
        {
            InitializeComponent();
            AppManager.GetInstance.LoginEvent += switchUser;
        }

        private void switchUser()
        {
            //disableButtons();
            m_LoggedInUser = AppManager.GetInstance.LoggedInUser;
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureLargeURL);
            fullNameUser.Text = m_LoggedInUser.Name;
            //updateInfo();
        }

        private void loadEvents()
        {
            m_Events = m_LoggedInUser.Events.Take(r_MaximumNumberOfEventsToShow).ToList();
            sendButtonForChange(showEventsButton, "Show Events", "No Events", System.Drawing.Color.Orange, m_Events);
        }

        private void changeButton(Control i_Ctrl, string i_Text, System.Drawing.Color i_Color, bool i_Enable)
        {
            if (i_Ctrl.InvokeRequired)
            {
                ChangeMyButtonDelegate del = new ChangeMyButtonDelegate(changeButton);
                i_Ctrl.Invoke(del, i_Ctrl, i_Text, i_Color, i_Enable);
            }
            else
            {
                i_Ctrl.Text = i_Text;
                i_Ctrl.BackColor = i_Color;
                i_Ctrl.Enabled = i_Enable;
            }
        }

        public static void ChangeControlText(Control i_Ctrl, string i_Text)
        {
            i_Ctrl.Text = i_Text;
        }

        private void sendButtonForChange<T>(
            Control i_Control,
            string i_Text1,
            string i_Text2,
            System.Drawing.Color i_Color,
            List<T> i_Collection)
        {
            string text = i_Collection.Count > 0 ? i_Text1 : i_Text2;
            bool enable = i_Collection.Count > 0;
            System.Drawing.Color color = i_Collection.Count > 0 ? i_Color : System.Drawing.Color.Empty;
            changeButton(i_Control, text, color, enable);
        }

        private void loadPosts()
        {
            m_Posts = m_LoggedInUser.Posts.Take(r_MaximumNumberOfPostsToShow).ToList();
            sendButtonForChange(showPostsButton, "Show Posts", "No Posts", System.Drawing.Color.Blue, m_Posts);
        }

        private void loadFriends()
        {
            m_Friends = m_LoggedInUser.Friends.Take(r_MaximumNumberOfFriendsToShow).ToList();
            sendButtonForChange(showFriendsButton, "Show Friends", "No Friends", System.Drawing.Color.Green, m_Friends);
        }

        private void updateInfo()
        {
            new Thread(loadEvents).Start();
            new Thread(loadPosts).Start();
            new Thread(loadFriends).Start();
        }
        //public MainPageForm(User i_User)
        //{
        //    InitializeComponent();
        //    FacebookService.s_CollectionLimit = 200;
        //    FacebookService.s_FbApiVersion = 2.8f;

        //    r_LoggedInUser = i_User;
        //    profilePictureBox.LoadAsync(r_LoggedInUser.PictureLargeURL);
        //    fullNameUser.Text = r_LoggedInUser.Name;
        //}

        private void fetchEvents()
        {
            int counter = 0;
            foreach (Event eventFSB in m_LoggedInUser.Events)
            {
                if (counter == r_MaximumNumberOfEventsToShow)
                {
                    break;
                }
                else
                {
                    comboBoxDecisionData.Items.Add(eventFSB.Name);
                }

                counter++;
            }

            if (m_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No events to retrieve!");
            }
        }

        private void fetchPosts()
        {
            int counter = 0;
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if (counter == r_MaximumNumberOfPostsToShow)
                {
                    break;
                }
                else if (post.Message != null)
                {
                    comboBoxDecisionData.Items.Add(post.Message);
                }
                else if (post.Caption != null)
                {
                    comboBoxDecisionData.Items.Add(post.Caption);
                }
                else
                {
                    comboBoxDecisionData.Items.Add(string.Format("[{0}]", post.Type));
                }

                counter++;
            }

            if (m_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No posts to retrieve!");
            }
        }

        private void fetchFriends()
        {
            comboBoxDecisionData.Items.Clear();
            comboBoxDecisionData.DisplayMember = "Name";
            int counter = 0;

            foreach (User friend in m_LoggedInUser.Friends)
            {
                if (counter == r_MaximumNumberOfFriendsToShow)
                {
                    break;
                }

                comboBoxDecisionData.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                counter++;
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve!");
            }
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            try
            {
                m_LoggedInUser.PostStatus(postTextBox.Text);
                MessageBox.Show(string.Format("Status Posted! {0}{1}", Environment.NewLine, postTextBox.Text));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not post.");
            }
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Events;
            fetchEvents();
        }

        private void ShowPostsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Posts;
            fetchPosts();
        }

        private void ShowFriendsButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Friends;
            fetchFriends();
        }

        private void GetMatchesButton_Click(object sender, EventArgs e)
        {
            cleanDataSelcetedComboBoxAndAnalyst();
            DataAnalyst.ButtonClicked = DataAnalyst.LastButtonClicked.Friends;

            List<User> friendsToMatchWith = AvailableFriends.GetAvailabeFriends(m_LoggedInUser);
            int counter = 0;
            foreach (User friend in friendsToMatchWith)
            {
                if (counter == r_MaximumNumberOfFriendsToShow)
                {
                    break;
                }

                comboBoxDecisionData.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                counter++;
            }

            if (friendsToMatchWith.Count == 0)
            {
                MessageBox.Show("Could not find anyone for you.");
            }
        }

        private void cleanDataSelcetedComboBoxAndAnalyst()
        {
            comboBoxDecisionData.Items.Clear();
            dataAnalystRichBox.Text = string.Empty;
            dataAnalystRichBox.Visible = false;

            resetDataAnalyst();
        }

        private void comboBoxDecisionData_SelectedIndexChanged(object sender, EventArgs e)
        {
            resetDataAnalyst();
            showAnalayzeResults(DataAnalyst.AnalyzeData(comboBoxDecisionData.SelectedIndex, m_LoggedInUser));
        }

        private void resetDataAnalyst()
        {
            dataAnalystRichBox.Clear();
            dataAnalystRichBox.Visible = false;
            
            dataSelectedPictureBox.Image = null;
            dataSelectedPictureBox.Visible = false;
        }

        private void showAnalayzeResults(List<string> i_Data)
        {
            string imageUrl = i_Data[1];
            string dataAnalyzed = i_Data[0];
            dataAnalystRichBox.Visible = true;

            if (string.IsNullOrEmpty(imageUrl) == false)
            {
                dataSelectedPictureBox.Visible = true;
                dataSelectedPictureBox.LoadAsync(imageUrl);
            }

            dataAnalystRichBox.Text = dataAnalyzed;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppManager.GetInstance.NextPage("UserInformation");
            
            //if (ProfileLinkClicked != null)
            //{
            //    ProfileLinkClicked.Invoke();
            //}
        }

        private void ZodiakSignLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AppManager.GetInstance.NextPage("ZodiacSignForm");

            //if (ZodiacLinkClicked != null)
            //{
            //    ZodiacLinkClicked.Invoke();
            //}
        }

        private void clearFields()
        {
            m_Events = null;
            m_Friends = null;
            m_Matches = null;
            m_Posts = null;

            //eventBindingSource.Clear();
            //postBindingSource.Clear();
            //userBindingSource.Clear();
            //matchesComboBox1.Items.Clear();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            clearFields();
            AppManager.GetInstance.Logout();
            //if (LogoutButtonClicked != null)
            //{
            //    LogoutButtonClicked.Invoke();
            //}
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {

        }
    }
}

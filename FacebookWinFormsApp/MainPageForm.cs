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
        private readonly int r_ScoreToDetermineMatch = 2;

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
            disableButtons();
            m_LoggedInUser = AppManager.GetInstance.LoggedInUser;
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureLargeURL);
            fullNameUser.Text = m_LoggedInUser.Name;
            updateInfo();
        }

        private void disableButtons()
        {
            showFriendsButton.Enabled = false;
            showFriendsButton.Text = "Loading Friends";
            showFriendsButton.BackColor = System.Drawing.Color.Gray;
            getMatchesButton.Text = "Show Matches";
            getMatchesButton.Enabled = false;
            getMatchesButton.BackColor = System.Drawing.Color.Gray;
            showPostsButton.Enabled = false;
            showPostsButton.Text = "Loading Posts";
            showPostsButton.BackColor = System.Drawing.Color.Gray;
            showEventsButton.Enabled = false;
            showEventsButton.Text = "Loading Events";
            showEventsButton.BackColor = System.Drawing.Color.Gray;
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
            sendButtonForChange(getMatchesButton, "Show Matches", "Show Matches", System.Drawing.Color.Purple, m_Friends);

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
            if (!eventsListBox.InvokeRequired)
            {
                eventBindingSource.DataSource = m_Events;
            }
            else
            {
                eventsListBox.Invoke(new Action(() => eventBindingSource.DataSource = m_Events));
            }
        }

        private void fetchPosts()
        {
            if (!postsListBox.InvokeRequired)
            {
                postBindingSource.DataSource = m_Posts;
            }
            else
            {
                postsListBox.Invoke(new Action(() => postBindingSource.DataSource = m_Posts));
            }
        }

        private void fetchFriends()
        {
            if (!friendsListBox.InvokeRequired)
            {
                userBindingSource.DataSource = m_Friends;
            }
            else
            {
                friendsListBox.Invoke(new Action(() => userBindingSource.DataSource = m_Friends));
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
                throw ex;
            }
        }

        private void ShowEventsButton_Click(object sender, EventArgs e)
        {
            if (showEventsButton.Enabled)
            {
                fetchEvents();
            }
        }

        private void ShowPostsButton_Click(object sender, EventArgs e)
        {
            if (showPostsButton.Enabled)
            {
                fetchPosts();
            }
        }

        private void showFriendsButton_Click(object sender, EventArgs e)
        {
            if (showFriendsButton.Enabled)
            {
                fetchFriends();
                friendsListBox.DisplayMember = "Name";
            }
        }

        private void GetMatchesButton_Click(object sender, EventArgs e)
        {
            LinkedList<ChainOfHandlers.eFilters> listOfOptionalFilters = createListOfOptionalFilters();
            FriendsToMatch friendsThatCanBeMatched = new FriendsToMatch(m_LoggedInUser, m_Friends, listOfOptionalFilters, r_ScoreToDetermineMatch);
            int counter = 0;

            foreach (User friend in friendsThatCanBeMatched)
            {
                if (counter == r_MaximumNumberOfFriendsToShow)
                {
                    break;
                }

                matchesComboBox1.Items.Add(friend);
                counter++;
            }

            if (counter == 0)
            {
                MessageBox.Show("Could not find anyone for you.");
            }
            // ------------------------ old !! ------------------------------
            //m_Matches = AvailableFriends.GetAvailabeFriends(m_LoggedInUser);
            //int counter = 0;
            //foreach (User friend in m_Matches)
            //{
            //    if (counter == r_MaximumNumberOfFriendsToShow)
            //    {
            //        break;
            //    }

            //    matchesComboBox1.Items.Add(friend);
            //    friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
            //    counter++;
            //}

            //if (m_Matches.Count == 0)
            //{
            //    MessageBox.Show("Could not find anyone for you.");
            //}
        }
        private LinkedList<ChainOfHandlers.eFilters> createListOfOptionalFilters()
        {
            LinkedList<ChainOfHandlers.eFilters> listOfFiltersENums = new LinkedList<ChainOfHandlers.eFilters>();
            if (educatedCheckBox.Checked == true)
            {
                listOfFiltersENums.AddLast(ChainOfHandlers.eFilters.Educated);
            }

            if (workExpCheckBox.Checked == true)
            {
                listOfFiltersENums.AddLast(ChainOfHandlers.eFilters.WorkExperience);
            }

            if (popularCheckBox.Checked == true)
            {
                listOfFiltersENums.AddLast(ChainOfHandlers.eFilters.Popular);
            }

            if (sameRegionCheckBox.Checked == true)
            {
                listOfFiltersENums.AddLast(ChainOfHandlers.eFilters.SameReligion);
            }

            if (sameTownCheckBox.Checked == true)
            {
                listOfFiltersENums.AddLast(ChainOfHandlers.eFilters.SameTown);
            }

            return listOfFiltersENums;
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

        private void MainPageForm_Load_1(object sender, EventArgs e)
        {

        }
    }
}

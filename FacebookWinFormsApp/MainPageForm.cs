﻿using FacebookWrapper;
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
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    internal partial class MainPageForm : Form
    {
        private readonly int r_MaximumNumberOfFriendsToShow = 10;
        private readonly int r_MaximumNumberOfPostsToShow = 15;
        private readonly int r_MaximumNumberOfEventsToShow = 15;

        internal delegate void LinkEventHandler();

        internal event LinkEventHandler ProfileLinkClicked;

        internal event LinkEventHandler ZodiacLinkClicked;

        internal event LinkEventHandler LogoutButtonClicked;

        private readonly User r_LoggedInUser;

        public MainPageForm(User i_User)
        {
            InitializeComponent();
            FacebookService.s_CollectionLimit = 200;
            FacebookService.s_FbApiVersion = 2.8f;

            r_LoggedInUser = i_User;
            profilePictureBox.LoadAsync(r_LoggedInUser.PictureLargeURL);
            fullNameUser.Text = r_LoggedInUser.Name;
        }

        private void fetchEvents()
        {
            int counter = 0;
            foreach (Event eventFSB in r_LoggedInUser.Events)
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

            if (r_LoggedInUser.Events.Count == 0)
            {
                MessageBox.Show("No events to retrieve!");
            }
        }

        private void fetchPosts()
        {
            int counter = 0;
            foreach (Post post in r_LoggedInUser.Posts)
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

            if (r_LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("No posts to retrieve!");
            }
        }

        private void fetchFriends()
        {
            comboBoxDecisionData.Items.Clear();
            comboBoxDecisionData.DisplayMember = "Name";
            int counter = 0;

            foreach (User friend in r_LoggedInUser.Friends)
            {
                if (counter == r_MaximumNumberOfFriendsToShow)
                {
                    break;
                }

                comboBoxDecisionData.Items.Add(friend);
                friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                counter++;
            }

            if (r_LoggedInUser.Friends.Count == 0)
            {
                MessageBox.Show("No Friends to retrieve!");
            }
        }

        private void PostButton_Click(object sender, EventArgs e)
        {
            try
            {
                r_LoggedInUser.PostStatus(postTextBox.Text);
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

            List<User> friendsToMatchWith = AvailableFriends.GetAvailabeFriends(r_LoggedInUser);
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
            showAnalayzeResults(DataAnalyst.AnalyzeData(comboBoxDecisionData.SelectedIndex, r_LoggedInUser));
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
            if (ProfileLinkClicked != null)
            {
                ProfileLinkClicked.Invoke();
            }
        }

        private void ZodiakSignLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ZodiacLinkClicked != null)
            {
                ZodiacLinkClicked.Invoke();
            }
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            if (LogoutButtonClicked != null)
            {
                LogoutButtonClicked.Invoke();
            }
        }

        private void MainPageForm_Load(object sender, EventArgs e)
        {

        }
    }
}

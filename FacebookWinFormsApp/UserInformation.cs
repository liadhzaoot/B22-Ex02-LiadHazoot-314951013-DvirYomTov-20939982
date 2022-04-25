using FacebookWrapper.ObjectModel;
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
    internal partial class UserInformation : Form
    {
        private User m_LoggedInUser;
        private readonly int r_MaximumNumberOfPostsToShow = 15;

        internal delegate void BackButtonEventHandler();

        internal event BackButtonEventHandler BackButtonClicked;

        internal UserInformation()
        {
            InitializeComponent();
            AppManager.GetInstance.LoginEvent += switchUser;
            
        }

        private void switchUser()
        {
            m_LoggedInUser = AppManager.GetInstance.LoggedInUser;
            fetchUserInfo();
            fetchPhotos();
        }

        //internal UserInformation(User i_User)
        //{
        //    InitializeComponent();
        //    m_LoggedInUser = i_User;
        //}

        internal void fetchOnLoad()
        {
            fetchUserInfo();
        }

        private void fetchUserInfo()
        {
            nameLabel.Text = m_LoggedInUser.Name;
            birthdayLabel.Text = m_LoggedInUser.Birthday;
            emailLabel.Text = m_LoggedInUser.Email;
            profilePictureBox.LoadAsync(m_LoggedInUser.PictureLargeURL);
        }

        private void showAlbums()
        {
            int counter = 0;
            foreach (Album album in m_LoggedInUser.Albums)
            {
                if (counter == r_MaximumNumberOfPostsToShow)
                {
                    break;
                }

                PostUC postUC = new PostUC();
                if (album.Name != null)
                {
                    postUC.SetLableText(album.Name);
                }
                if (album.PictureAlbumURL != null)
                {
                    postUC.SetImage(album.PictureAlbumURL);
                }

                this.flowLayoutPanel1.Controls.Add(postUC);
                counter++;
            }

            this.flowLayoutPanel1.AutoScroll = true;
        }
        private void createFeed()
        {
            int counter = 0;
            foreach (Post post in m_LoggedInUser.Posts)
            {
                if(counter == r_MaximumNumberOfPostsToShow)
                {
                    break;
                }

                PostUC postUC = new PostUC();
                //postUC.SetLableVisibility(false);
                if (post.Message != null)
                {
                    //postUC.SetLableVisibility(true);
                    postUC.SetLableText(post.Message);
                }

                if (post.PictureURL != null)
                {
                    postUC.SetImage(post.PictureURL);
                }
                this.flowLayoutPanel1.Controls.Add(postUC);
                counter++;
            }

            this.flowLayoutPanel1.AutoScroll = true;
        }

        private void fetchPhotos()
        {
            IEnumerator<Photo> photosEnumerator = m_LoggedInUser.PhotosTaggedIn.GetEnumerator();
            for (int i = 0; i < r_MaximumNumberOfPostsToShow; i++)
            {
                PostUC postUC = new PostUC();

                if (photosEnumerator.MoveNext())
                {
                    postUC.SetImage(photosEnumerator.Current.PictureNormalURL);
                }
                else
                {
                    break;
                }
                this.flowLayoutPanel1.Controls.Add(postUC);
                this.flowLayoutPanel1.AutoScroll = true;

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            AppManager.GetInstance.Back();
            //if (BackButtonClicked != null)
            //{
            //    BackButtonClicked.Invoke();
            //}
        }

        private void showFeedBtn_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            createFeed();
        }

        private void ShowAlbumsBtn_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            showAlbums();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void taggedPhotos_Click(object sender, EventArgs e)
        {
            this.flowLayoutPanel1.Controls.Clear();
            fetchPhotos();
        }

        //private void backButton_Click(object sender, EventArgs e)
        //{
        //    AppManager.GetInstance.Back();
        //}

        private void UserInformation_Load(object sender, EventArgs e)
        {

        }
    }
}

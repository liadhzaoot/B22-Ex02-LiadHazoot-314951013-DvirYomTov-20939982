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
        private readonly User r_User;
        private List<PictureBox> m_PictureBoxes;
        private readonly int r_MaximumNumberOfPostsToShow = 15;

        internal delegate void BackButtonEventHandler();

        internal event BackButtonEventHandler BackButtonClicked;

        internal UserInformation(User i_User)
        {
            InitializeComponent();
            r_User = i_User;
        }

        internal void fetchOnLoad()
        {
            fetchUserInfo();
            fetchPhotos();
        }

        private void fetchUserInfo()
        {
            nameLabel.Text = r_User.Name;
            birthdayLabel.Text = r_User.Birthday;
            emailLabel.Text = r_User.Email;
            profilePictureBox.LoadAsync(r_User.PictureLargeURL);
        }

        private void showAlbums()
        {
            int counter = 0;
            foreach (Album album in r_User.Albums)
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
            foreach (Post post in r_User.Posts)
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
            IEnumerator<Photo> photosEnumerator = r_User.PhotosTaggedIn.GetEnumerator();
            foreach (PictureBox pictureBox in m_PictureBoxes)
            {
                if (photosEnumerator.MoveNext())
                {
                    pictureBox.LoadAsync(photosEnumerator.Current.PictureNormalURL);
                    pictureBox.Visible = true;
                }
                else
                {
                    break;
                }
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            if (BackButtonClicked != null)
            {
                BackButtonClicked.Invoke();
            }
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
    }
}

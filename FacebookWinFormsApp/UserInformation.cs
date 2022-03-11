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
            for (int i = 0; i < r_User.Albums.Count; i++)
            {
                PostUC postUC = new PostUC();
                if (r_User.Albums[i].Name != null)
                {
                    postUC.SetLableText(r_User.Albums[i].Name);
                }
                if (r_User.Albums[i].PictureAlbumURL != null)
                {
                    postUC.SetImage(r_User.Albums[i].PictureAlbumURL);
                }

                this.flowLayoutPanel1.Controls.Add(postUC);
            }

            this.flowLayoutPanel1.AutoScroll = true;
        }
        private void createFeed()
        {
            for (int i = 0; i < r_User.Posts.Count; i++)
            {
                PostUC postUC = new PostUC();
                //postUC.SetLableVisibility(false);
                if (r_User.Posts[i].Message != null)
                {
                    //postUC.SetLableVisibility(true);
                    postUC.SetLableText(r_User.Posts[i].Message);
                }

                if (r_User.Posts[i].PictureURL != null)
                {
                    postUC.SetImage(r_User.Posts[i].PictureURL);
                }
                this.flowLayoutPanel1.Controls.Add(postUC);

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

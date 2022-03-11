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
    public delegate void ChengePostHandler(string i_Lable, string i_PictureUrl);

    public partial class PostUC : UserControl
    {
        public event ChengePostHandler m_ChangePost;
        public PostUC()
        {
            InitializeComponent();
        }

        private void PostUC_Load(object sender, EventArgs e)
        {

        }

        private void chromiumWebBrowser1_LoadingStateChanged(object sender, CefSharp.LoadingStateChangedEventArgs e)
        {

        }

        private void postLable_Click(object sender, EventArgs e)
        {

        }
        public void SetImage(string i_PicturUrl)
        {
            this.postPB.LoadAsync(i_PicturUrl);
        }
        public void SetLableText(string i_Lable)
        {
            this.postLable.Text = i_Lable;
        }
        public void SetLableVisibility(bool k_IsVisible)
        {
            this.postLable.Visible = false;
        }
        private void postPB_Click(object sender, EventArgs e)
        {

        }
    }
}


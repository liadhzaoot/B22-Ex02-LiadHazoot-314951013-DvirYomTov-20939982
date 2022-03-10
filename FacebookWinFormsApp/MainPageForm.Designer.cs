﻿namespace BasicFacebookFeatures
{
    partial class MainPageForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPageForm));
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.ChooseDataTypeLabel = new System.Windows.Forms.Label();
            this.comboBoxDecisionData = new System.Windows.Forms.ListBox();
            this.SelectedOptionDataLable = new System.Windows.Forms.Label();
            this.postButton = new System.Windows.Forms.Button();
            this.postTextBox = new System.Windows.Forms.TextBox();
            this.postLabel = new System.Windows.Forms.Label();
            this.fullNameUser = new System.Windows.Forms.Label();
            this.dataAnalystRichBox = new System.Windows.Forms.RichTextBox();
            this.showPostsButton = new System.Windows.Forms.Button();
            this.showEventsButton = new System.Windows.Forms.Button();
            this.dataSelectedPictureBox = new System.Windows.Forms.PictureBox();
            this.friendFirstNameLabel = new System.Windows.Forms.Label();
            this.friendLastNameLabel = new System.Windows.Forms.Label();
            this.showFriendsButton = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.GetMatchesButton = new System.Windows.Forms.Button();
            this.ZodiakSignLink = new System.Windows.Forms.LinkLabel();
            this.logoutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Location = new System.Drawing.Point(31, 27);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(173, 145);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // ChooseDataTypeLabel
            // 
            this.ChooseDataTypeLabel.AutoSize = true;
            this.ChooseDataTypeLabel.BackColor = System.Drawing.Color.Transparent;
            this.ChooseDataTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChooseDataTypeLabel.Location = new System.Drawing.Point(365, 236);
            this.ChooseDataTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseDataTypeLabel.Name = "ChooseDataTypeLabel";
            this.ChooseDataTypeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ChooseDataTypeLabel.Size = new System.Drawing.Size(406, 36);
            this.ChooseDataTypeLabel.TabIndex = 20;
            this.ChooseDataTypeLabel.Text = "What would you like to see:";
            // 
            // comboBoxDecisionData
            // 
            this.comboBoxDecisionData.BackColor = System.Drawing.Color.DarkSalmon;
            this.comboBoxDecisionData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDecisionData.FormattingEnabled = true;
            this.comboBoxDecisionData.ItemHeight = 20;
            this.comboBoxDecisionData.Location = new System.Drawing.Point(89, 383);
            this.comboBoxDecisionData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDecisionData.Name = "comboBoxDecisionData";
            this.comboBoxDecisionData.Size = new System.Drawing.Size(224, 324);
            this.comboBoxDecisionData.TabIndex = 19;
            this.comboBoxDecisionData.SelectedIndexChanged += new System.EventHandler(this.comboBoxDecisionData_SelectedIndexChanged);
            // 
            // SelectedOptionDataLable
            // 
            this.SelectedOptionDataLable.AutoSize = true;
            this.SelectedOptionDataLable.BackColor = System.Drawing.Color.Transparent;
            this.SelectedOptionDataLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedOptionDataLable.Location = new System.Drawing.Point(84, 354);
            this.SelectedOptionDataLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SelectedOptionDataLable.Name = "SelectedOptionDataLable";
            this.SelectedOptionDataLable.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SelectedOptionDataLable.Size = new System.Drawing.Size(112, 25);
            this.SelectedOptionDataLable.TabIndex = 18;
            this.SelectedOptionDataLable.Text = "Your data:";
            // 
            // postButton
            // 
            this.postButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postButton.Location = new System.Drawing.Point(1028, 188);
            this.postButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postButton.Name = "postButton";
            this.postButton.Size = new System.Drawing.Size(129, 39);
            this.postButton.TabIndex = 17;
            this.postButton.Text = "Post";
            this.postButton.UseVisualStyleBackColor = true;
            this.postButton.Click += new System.EventHandler(this.PostButton_Click);
            // 
            // postTextBox
            // 
            this.postTextBox.Location = new System.Drawing.Point(300, 198);
            this.postTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.postTextBox.Name = "postTextBox";
            this.postTextBox.Size = new System.Drawing.Size(719, 22);
            this.postTextBox.TabIndex = 22;
            // 
            // postLabel
            // 
            this.postLabel.AutoSize = true;
            this.postLabel.BackColor = System.Drawing.Color.Transparent;
            this.postLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.postLabel.Location = new System.Drawing.Point(24, 188);
            this.postLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postLabel.Name = "postLabel";
            this.postLabel.Size = new System.Drawing.Size(260, 36);
            this.postLabel.TabIndex = 16;
            this.postLabel.Text = "Write new status:";
            // 
            // fullNameUser
            // 
            this.fullNameUser.AutoSize = true;
            this.fullNameUser.BackColor = System.Drawing.Color.Transparent;
            this.fullNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameUser.Location = new System.Drawing.Point(212, 43);
            this.fullNameUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNameUser.Name = "fullNameUser";
            this.fullNameUser.Size = new System.Drawing.Size(300, 69);
            this.fullNameUser.TabIndex = 13;
            this.fullNameUser.Text = "Full name";
            // 
            // dataAnalystRichBox
            // 
            this.dataAnalystRichBox.BackColor = System.Drawing.Color.DarkSalmon;
            this.dataAnalystRichBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataAnalystRichBox.Location = new System.Drawing.Point(359, 383);
            this.dataAnalystRichBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataAnalystRichBox.Name = "dataAnalystRichBox";
            this.dataAnalystRichBox.ReadOnly = true;
            this.dataAnalystRichBox.Size = new System.Drawing.Size(403, 340);
            this.dataAnalystRichBox.TabIndex = 24;
            this.dataAnalystRichBox.Text = "";
            this.dataAnalystRichBox.Visible = false;
            // 
            // showPostsButton
            // 
            this.showPostsButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.showPostsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showPostsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showPostsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.showPostsButton.Location = new System.Drawing.Point(31, 277);
            this.showPostsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showPostsButton.Name = "showPostsButton";
            this.showPostsButton.Size = new System.Drawing.Size(279, 53);
            this.showPostsButton.TabIndex = 25;
            this.showPostsButton.Text = "Show Posts";
            this.showPostsButton.UseVisualStyleBackColor = false;
            this.showPostsButton.Click += new System.EventHandler(this.ShowPostsButton_Click);
            // 
            // showEventsButton
            // 
            this.showEventsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.showEventsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showEventsButton.Location = new System.Drawing.Point(584, 277);
            this.showEventsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showEventsButton.Name = "showEventsButton";
            this.showEventsButton.Size = new System.Drawing.Size(279, 53);
            this.showEventsButton.TabIndex = 26;
            this.showEventsButton.Text = "Show Events";
            this.showEventsButton.UseVisualStyleBackColor = false;
            this.showEventsButton.Click += new System.EventHandler(this.ShowEventsButton_Click);
            // 
            // dataSelectedPictureBox
            // 
            this.dataSelectedPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.dataSelectedPictureBox.Location = new System.Drawing.Point(771, 383);
            this.dataSelectedPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataSelectedPictureBox.Name = "dataSelectedPictureBox";
            this.dataSelectedPictureBox.Size = new System.Drawing.Size(308, 246);
            this.dataSelectedPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.dataSelectedPictureBox.TabIndex = 27;
            this.dataSelectedPictureBox.TabStop = false;
            this.dataSelectedPictureBox.Visible = false;
            // 
            // friendFirstNameLabel
            // 
            this.friendFirstNameLabel.AutoSize = true;
            this.friendFirstNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.friendFirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendFirstNameLabel.Location = new System.Drawing.Point(772, 638);
            this.friendFirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.friendFirstNameLabel.Name = "friendFirstNameLabel";
            this.friendFirstNameLabel.Size = new System.Drawing.Size(168, 36);
            this.friendFirstNameLabel.TabIndex = 28;
            this.friendFirstNameLabel.Text = "First Name";
            this.friendFirstNameLabel.Visible = false;
            // 
            // friendLastNameLabel
            // 
            this.friendLastNameLabel.AutoSize = true;
            this.friendLastNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.friendLastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendLastNameLabel.Location = new System.Drawing.Point(772, 673);
            this.friendLastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.friendLastNameLabel.Name = "friendLastNameLabel";
            this.friendLastNameLabel.Size = new System.Drawing.Size(156, 36);
            this.friendLastNameLabel.TabIndex = 29;
            this.friendLastNameLabel.Text = "Last Name";
            this.friendLastNameLabel.Visible = false;
            // 
            // showFriendsButton
            // 
            this.showFriendsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.showFriendsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFriendsButton.Location = new System.Drawing.Point(307, 277);
            this.showFriendsButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showFriendsButton.Name = "showFriendsButton";
            this.showFriendsButton.Size = new System.Drawing.Size(279, 53);
            this.showFriendsButton.TabIndex = 30;
            this.showFriendsButton.Text = "Show Friends";
            this.showFriendsButton.UseVisualStyleBackColor = false;
            this.showFriendsButton.Click += new System.EventHandler(this.ShowFriendsButton_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(231, 118);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(90, 29);
            this.linkLabel2.TabIndex = 32;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Profile";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // GetMatchesButton
            // 
            this.GetMatchesButton.BackColor = System.Drawing.Color.Purple;
            this.GetMatchesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GetMatchesButton.Location = new System.Drawing.Point(860, 277);
            this.GetMatchesButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GetMatchesButton.Name = "GetMatchesButton";
            this.GetMatchesButton.Size = new System.Drawing.Size(279, 53);
            this.GetMatchesButton.TabIndex = 33;
            this.GetMatchesButton.Text = "Get Matches";
            this.GetMatchesButton.UseVisualStyleBackColor = false;
            this.GetMatchesButton.Click += new System.EventHandler(this.GetMatchesButton_Click);
            // 
            // ZodiakSignLink
            // 
            this.ZodiakSignLink.AutoSize = true;
            this.ZodiakSignLink.BackColor = System.Drawing.Color.Transparent;
            this.ZodiakSignLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ZodiakSignLink.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ZodiakSignLink.Location = new System.Drawing.Point(229, 148);
            this.ZodiakSignLink.Name = "ZodiakSignLink";
            this.ZodiakSignLink.Size = new System.Drawing.Size(141, 29);
            this.ZodiakSignLink.TabIndex = 34;
            this.ZodiakSignLink.TabStop = true;
            this.ZodiakSignLink.Text = "Find Match";
            this.ZodiakSignLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ZodiakSignLink_LinkClicked);
            // 
            // logoutButton
            // 
            this.logoutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.logoutButton.Location = new System.Drawing.Point(1036, 27);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(108, 38);
            this.logoutButton.TabIndex = 35;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // MainPageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1179, 814);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.ZodiakSignLink);
            this.Controls.Add(this.GetMatchesButton);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.showFriendsButton);
            this.Controls.Add(this.friendLastNameLabel);
            this.Controls.Add(this.friendFirstNameLabel);
            this.Controls.Add(this.dataSelectedPictureBox);
            this.Controls.Add(this.showEventsButton);
            this.Controls.Add(this.showPostsButton);
            this.Controls.Add(this.dataAnalystRichBox);
            this.Controls.Add(this.ChooseDataTypeLabel);
            this.Controls.Add(this.comboBoxDecisionData);
            this.Controls.Add(this.SelectedOptionDataLable);
            this.Controls.Add(this.postButton);
            this.Controls.Add(this.postTextBox);
            this.Controls.Add(this.postLabel);
            this.Controls.Add(this.fullNameUser);
            this.Controls.Add(this.profilePictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "MainPageForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = " ";
            this.Load += new System.EventHandler(this.MainPageForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSelectedPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.Label ChooseDataTypeLabel;
        private System.Windows.Forms.ListBox comboBoxDecisionData;
        private System.Windows.Forms.Label SelectedOptionDataLable;
        private System.Windows.Forms.Button postButton;
        private System.Windows.Forms.TextBox postTextBox;
        private System.Windows.Forms.Label postLabel;
        private System.Windows.Forms.Label fullNameUser;
        private System.Windows.Forms.RichTextBox dataAnalystRichBox;
        private System.Windows.Forms.Button showPostsButton;
        private System.Windows.Forms.Button showEventsButton;
        private System.Windows.Forms.PictureBox dataSelectedPictureBox;
        private System.Windows.Forms.Label friendFirstNameLabel;
        private System.Windows.Forms.Label friendLastNameLabel;
        private System.Windows.Forms.Button showFriendsButton;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button GetMatchesButton;
        private System.Windows.Forms.LinkLabel ZodiakSignLink;
        private System.Windows.Forms.Button logoutButton;
    }
}
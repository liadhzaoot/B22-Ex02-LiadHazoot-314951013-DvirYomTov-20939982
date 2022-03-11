namespace BasicFacebookFeatures
{
    partial class UserInformation
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.birthdayLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.profilePictureBox = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.showFeedBtn = new System.Windows.Forms.Button();
            this.ShowAlbumsBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nameLabel.Location = new System.Drawing.Point(11, 255);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(152, 31);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "NameLabel";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.Transparent;
            this.emailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.emailLabel.Location = new System.Drawing.Point(12, 294);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(103, 24);
            this.emailLabel.TabIndex = 3;
            this.emailLabel.Text = "EmailLabel";
            // 
            // birthdayLabel
            // 
            this.birthdayLabel.AutoSize = true;
            this.birthdayLabel.BackColor = System.Drawing.Color.Transparent;
            this.birthdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.birthdayLabel.Location = new System.Drawing.Point(12, 319);
            this.birthdayLabel.Name = "birthdayLabel";
            this.birthdayLabel.Size = new System.Drawing.Size(79, 20);
            this.birthdayLabel.TabIndex = 4;
            this.birthdayLabel.Text = "AgeLable";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(17, 442);
            this.backButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(87, 34);
            this.backButton.TabIndex = 9;
            this.backButton.Text = "Go Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // profilePictureBox
            // 
            this.profilePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.profilePictureBox.Location = new System.Drawing.Point(16, 11);
            this.profilePictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.profilePictureBox.Name = "profilePictureBox";
            this.profilePictureBox.Size = new System.Drawing.Size(228, 210);
            this.profilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePictureBox.TabIndex = 1;
            this.profilePictureBox.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(331, 183);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(711, 621);
            this.flowLayoutPanel1.TabIndex = 10;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // showFeedBtn
            // 
            this.showFeedBtn.BackColor = System.Drawing.Color.LightCyan;
            this.showFeedBtn.Location = new System.Drawing.Point(421, 93);
            this.showFeedBtn.Name = "showFeedBtn";
            this.showFeedBtn.Size = new System.Drawing.Size(142, 41);
            this.showFeedBtn.TabIndex = 11;
            this.showFeedBtn.Text = "Show Feed";
            this.showFeedBtn.UseVisualStyleBackColor = false;
            this.showFeedBtn.Click += new System.EventHandler(this.showFeedBtn_Click);
            // 
            // ShowAlbumsBtn
            // 
            this.ShowAlbumsBtn.BackColor = System.Drawing.Color.LightCyan;
            this.ShowAlbumsBtn.Location = new System.Drawing.Point(780, 93);
            this.ShowAlbumsBtn.Name = "ShowAlbumsBtn";
            this.ShowAlbumsBtn.Size = new System.Drawing.Size(142, 41);
            this.ShowAlbumsBtn.TabIndex = 12;
            this.ShowAlbumsBtn.Text = "Show Albums";
            this.ShowAlbumsBtn.UseVisualStyleBackColor = false;
            this.ShowAlbumsBtn.Click += new System.EventHandler(this.ShowAlbumsBtn_Click);
            // 
            // UserInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 804);
            this.Controls.Add(this.ShowAlbumsBtn);
            this.Controls.Add(this.showFeedBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.birthdayLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.profilePictureBox);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1194, 851);
            this.MinimumSize = new System.Drawing.Size(1194, 851);
            this.Name = "UserInformation";
            this.Text = "UserInformation";
            ((System.ComponentModel.ISupportInitialize)(this.profilePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label birthdayLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.PictureBox profilePictureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button showFeedBtn;
        private System.Windows.Forms.Button ShowAlbumsBtn;
    }
}
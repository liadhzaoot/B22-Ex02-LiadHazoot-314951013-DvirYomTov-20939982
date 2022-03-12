namespace BasicFacebookFeatures
{
    partial class PostUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.postPB = new System.Windows.Forms.PictureBox();
            this.postLable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.postPB)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // postPB
            // 
            this.postPB.BackColor = System.Drawing.Color.LightCyan;
            this.postPB.Location = new System.Drawing.Point(148, 31);
            this.postPB.Margin = new System.Windows.Forms.Padding(4);
            this.postPB.Name = "postPB";
            this.postPB.Size = new System.Drawing.Size(317, 138);
            this.postPB.TabIndex = 4;
            this.postPB.TabStop = false;
            this.postPB.Click += new System.EventHandler(this.postPB_Click);
            // 
            // postLable
            // 
            this.postLable.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.postLable.AutoSize = true;
            this.postLable.Location = new System.Drawing.Point(270, 195);
            this.postLable.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.postLable.Name = "postLable";
            this.postLable.Size = new System.Drawing.Size(33, 16);
            this.postLable.TabIndex = 5;
            this.postLable.Text = "Text";
            this.postLable.Click += new System.EventHandler(this.postLable_Click);
            // 
            // PostUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.Controls.Add(this.postLable);
            this.Controls.Add(this.postPB);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PostUC";
            this.Size = new System.Drawing.Size(641, 380);
            this.Load += new System.EventHandler(this.PostUC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox postPB;
        private System.Windows.Forms.Label postLable;
    }
}


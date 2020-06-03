namespace Verstoppertje_App
{
    partial class userProfile_Page
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
            this.back_btn = new System.Windows.Forms.Button();
            this.userNickName_tBox = new System.Windows.Forms.TextBox();
            this.userNickName_label = new System.Windows.Forms.Label();
            this.userProfileName_Label = new System.Windows.Forms.Label();
            this.userProfileName_tBox = new System.Windows.Forms.TextBox();
            this.userProfileEmail_label = new System.Windows.Forms.Label();
            this.UserProfileEmail_tBox = new System.Windows.Forms.TextBox();
            this.UserProfilePic_pictureBox = new System.Windows.Forms.PictureBox();
            this.pictureUpload_btn = new System.Windows.Forms.Button();
            this.editProfile_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePic_pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // back_btn
            // 
            this.back_btn.Location = new System.Drawing.Point(686, 385);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(102, 53);
            this.back_btn.TabIndex = 0;
            this.back_btn.Text = "Back";
            this.back_btn.UseVisualStyleBackColor = true;
            // 
            // userNickName_tBox
            // 
            this.userNickName_tBox.Location = new System.Drawing.Point(100, 39);
            this.userNickName_tBox.Name = "userNickName_tBox";
            this.userNickName_tBox.Size = new System.Drawing.Size(100, 20);
            this.userNickName_tBox.TabIndex = 2;
            // 
            // userNickName_label
            // 
            this.userNickName_label.AutoSize = true;
            this.userNickName_label.Location = new System.Drawing.Point(28, 42);
            this.userNickName_label.Name = "userNickName_label";
            this.userNickName_label.Size = new System.Drawing.Size(60, 13);
            this.userNickName_label.TabIndex = 3;
            this.userNickName_label.Text = "Nick Name";
            // 
            // userProfileName_Label
            // 
            this.userProfileName_Label.AutoSize = true;
            this.userProfileName_Label.Location = new System.Drawing.Point(31, 71);
            this.userProfileName_Label.Name = "userProfileName_Label";
            this.userProfileName_Label.Size = new System.Drawing.Size(55, 13);
            this.userProfileName_Label.TabIndex = 4;
            this.userProfileName_Label.Text = "Username";
            // 
            // userProfileName_tBox
            // 
            this.userProfileName_tBox.Location = new System.Drawing.Point(100, 71);
            this.userProfileName_tBox.Name = "userProfileName_tBox";
            this.userProfileName_tBox.Size = new System.Drawing.Size(100, 20);
            this.userProfileName_tBox.TabIndex = 5;
            // 
            // userProfileEmail_label
            // 
            this.userProfileEmail_label.AutoSize = true;
            this.userProfileEmail_label.Location = new System.Drawing.Point(31, 99);
            this.userProfileEmail_label.Name = "userProfileEmail_label";
            this.userProfileEmail_label.Size = new System.Drawing.Size(32, 13);
            this.userProfileEmail_label.TabIndex = 6;
            this.userProfileEmail_label.Text = "Email";
            // 
            // UserProfileEmail_tBox
            // 
            this.UserProfileEmail_tBox.Location = new System.Drawing.Point(100, 99);
            this.UserProfileEmail_tBox.Name = "UserProfileEmail_tBox";
            this.UserProfileEmail_tBox.Size = new System.Drawing.Size(100, 20);
            this.UserProfileEmail_tBox.TabIndex = 7;
            // 
            // UserProfilePic_pictureBox
            // 
            this.UserProfilePic_pictureBox.Location = new System.Drawing.Point(561, 21);
            this.UserProfilePic_pictureBox.Name = "UserProfilePic_pictureBox";
            this.UserProfilePic_pictureBox.Size = new System.Drawing.Size(214, 194);
            this.UserProfilePic_pictureBox.TabIndex = 8;
            this.UserProfilePic_pictureBox.TabStop = false;
            // 
            // pictureUpload_btn
            // 
            this.pictureUpload_btn.Location = new System.Drawing.Point(700, 221);
            this.pictureUpload_btn.Name = "pictureUpload_btn";
            this.pictureUpload_btn.Size = new System.Drawing.Size(75, 23);
            this.pictureUpload_btn.TabIndex = 9;
            this.pictureUpload_btn.Text = "Upload";
            this.pictureUpload_btn.UseVisualStyleBackColor = true;
            // 
            // editProfile_btn
            // 
            this.editProfile_btn.Location = new System.Drawing.Point(686, 326);
            this.editProfile_btn.Name = "editProfile_btn";
            this.editProfile_btn.Size = new System.Drawing.Size(102, 53);
            this.editProfile_btn.TabIndex = 10;
            this.editProfile_btn.Text = "Edit Profile";
            this.editProfile_btn.UseVisualStyleBackColor = true;
            // 
            // userProfile_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editProfile_btn);
            this.Controls.Add(this.pictureUpload_btn);
            this.Controls.Add(this.UserProfilePic_pictureBox);
            this.Controls.Add(this.UserProfileEmail_tBox);
            this.Controls.Add(this.userProfileEmail_label);
            this.Controls.Add(this.userProfileName_tBox);
            this.Controls.Add(this.userProfileName_Label);
            this.Controls.Add(this.userNickName_label);
            this.Controls.Add(this.userNickName_tBox);
            this.Controls.Add(this.back_btn);
            this.Name = "userProfile_Page";
            this.Text = "My Profile";
            ((System.ComponentModel.ISupportInitialize)(this.UserProfilePic_pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_btn;
        private System.Windows.Forms.TextBox userNickName_tBox;
        private System.Windows.Forms.Label userNickName_label;
        private System.Windows.Forms.Label userProfileName_Label;
        private System.Windows.Forms.TextBox userProfileName_tBox;
        private System.Windows.Forms.Label userProfileEmail_label;
        private System.Windows.Forms.TextBox UserProfileEmail_tBox;
        private System.Windows.Forms.PictureBox UserProfilePic_pictureBox;
        private System.Windows.Forms.Button pictureUpload_btn;
        private System.Windows.Forms.Button editProfile_btn;
    }
}
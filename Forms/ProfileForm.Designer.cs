namespace Verstoppertje_App.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.profilePanel = new System.Windows.Forms.Panel();
            this.profileLabel = new System.Windows.Forms.Label();
            this.profilePicture = new System.Windows.Forms.PictureBox();
            this.usernameText = new System.Windows.Forms.TextBox();
            this.firstnameText = new System.Windows.Forms.TextBox();
            this.lastnameText = new System.Windows.Forms.TextBox();
            this.emailText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // profilePanel
            // 
            this.profilePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePanel.Controls.Add(this.label1);
            this.profilePanel.Controls.Add(this.saveButton);
            this.profilePanel.Controls.Add(this.passwordLabel);
            this.profilePanel.Controls.Add(this.emailLabel);
            this.profilePanel.Controls.Add(this.lastnameLabel);
            this.profilePanel.Controls.Add(this.firstnameLabel);
            this.profilePanel.Controls.Add(this.usernameLabel);
            this.profilePanel.Controls.Add(this.passwordText);
            this.profilePanel.Controls.Add(this.emailText);
            this.profilePanel.Controls.Add(this.lastnameText);
            this.profilePanel.Controls.Add(this.firstnameText);
            this.profilePanel.Controls.Add(this.usernameText);
            this.profilePanel.Controls.Add(this.profilePicture);
            this.profilePanel.Controls.Add(this.profileLabel);
            this.profilePanel.Location = new System.Drawing.Point(12, 12);
            this.profilePanel.Name = "profilePanel";
            this.profilePanel.Size = new System.Drawing.Size(890, 482);
            this.profilePanel.TabIndex = 0;
            // 
            // profileLabel
            // 
            this.profileLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profileLabel.AutoSize = true;
            this.profileLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 16.2F, System.Drawing.FontStyle.Bold);
            this.profileLabel.Location = new System.Drawing.Point(389, 20);
            this.profileLabel.Name = "profileLabel";
            this.profileLabel.Size = new System.Drawing.Size(113, 39);
            this.profileLabel.TabIndex = 0;
            this.profileLabel.Text = "Profile";
            // 
            // profilePicture
            // 
            this.profilePicture.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.profilePicture.Image = ((System.Drawing.Image)(resources.GetObject("profilePicture.Image")));
            this.profilePicture.Location = new System.Drawing.Point(114, 167);
            this.profilePicture.Name = "profilePicture";
            this.profilePicture.Size = new System.Drawing.Size(184, 151);
            this.profilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profilePicture.TabIndex = 1;
            this.profilePicture.TabStop = false;
            // 
            // usernameText
            // 
            this.usernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.usernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.usernameText.Location = new System.Drawing.Point(517, 132);
            this.usernameText.Name = "usernameText";
            this.usernameText.Size = new System.Drawing.Size(220, 28);
            this.usernameText.TabIndex = 2;
            // 
            // firstnameText
            // 
            this.firstnameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstnameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.firstnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.firstnameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.firstnameText.Location = new System.Drawing.Point(517, 176);
            this.firstnameText.Name = "firstnameText";
            this.firstnameText.Size = new System.Drawing.Size(220, 28);
            this.firstnameText.TabIndex = 3;
            // 
            // lastnameText
            // 
            this.lastnameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastnameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.lastnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lastnameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.lastnameText.Location = new System.Drawing.Point(517, 219);
            this.lastnameText.Name = "lastnameText";
            this.lastnameText.Size = new System.Drawing.Size(220, 28);
            this.lastnameText.TabIndex = 4;
            // 
            // emailText
            // 
            this.emailText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.emailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailText.ForeColor = System.Drawing.Color.Gainsboro;
            this.emailText.Location = new System.Drawing.Point(517, 263);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(220, 28);
            this.emailText.TabIndex = 5;
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordText.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordText.Location = new System.Drawing.Point(517, 309);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '•';
            this.passwordText.Size = new System.Drawing.Size(220, 28);
            this.passwordText.TabIndex = 6;
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(392, 134);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(98, 24);
            this.usernameLabel.TabIndex = 14;
            this.usernameLabel.Text = "Username";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(392, 178);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(102, 24);
            this.firstnameLabel.TabIndex = 15;
            this.firstnameLabel.Text = "First name";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Location = new System.Drawing.Point(392, 221);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(99, 24);
            this.lastnameLabel.TabIndex = 16;
            this.lastnameLabel.Text = "Last name";
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(392, 265);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 24);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "E-mail";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(392, 311);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 24);
            this.passwordLabel.TabIndex = 18;
            this.passwordLabel.Text = "Password";
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.saveButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.saveButton.Location = new System.Drawing.Point(625, 374);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 34);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(393, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 18);
            this.label1.TabIndex = 20;
            this.label1.Text = "Leave password empty if you do not wish to change your password";
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 506);
            this.Controls.Add(this.profilePanel);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProfileForm";
            this.Text = "ProfileForm";
            this.profilePanel.ResumeLayout(false);
            this.profilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel profilePanel;
        private System.Windows.Forms.PictureBox profilePicture;
        private System.Windows.Forms.Label profileLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.TextBox lastnameText;
        private System.Windows.Forms.TextBox firstnameText;
        private System.Windows.Forms.TextBox usernameText;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
    }
}
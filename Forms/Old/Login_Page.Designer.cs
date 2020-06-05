namespace Verstoppertje_App
{
    partial class login_Page
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
            System.Windows.Forms.TextBox emailBox;
            this.password_label = new System.Windows.Forms.Label();
            this.userPassword_tBox = new System.Windows.Forms.TextBox();
            this.rememberMe_cBox = new System.Windows.Forms.CheckBox();
            this.UserLogin_btn = new System.Windows.Forms.Button();
            this.UserSignUp_btn = new System.Windows.Forms.Button();
            this.ForgotMyPass_btn = new System.Windows.Forms.Button();
            this.userGameName_label = new System.Windows.Forms.Label();
            this.userGameName_tBox = new System.Windows.Forms.TextBox();
            this.exitGame_btn = new System.Windows.Forms.Button();
            this.loginPanel = new System.Windows.Forms.Panel();
            this.signupPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.lastnameBox = new System.Windows.Forms.TextBox();
            this.signupButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.firstnameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            emailBox = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.signupPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailBox
            // 
            emailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            emailBox.Location = new System.Drawing.Point(211, 292);
            emailBox.Margin = new System.Windows.Forms.Padding(5);
            emailBox.Name = "emailBox";
            emailBox.Size = new System.Drawing.Size(225, 28);
            emailBox.TabIndex = 11;
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(101, 214);
            this.password_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(78, 20);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // userPassword_tBox
            // 
            this.userPassword_tBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            this.userPassword_tBox.Location = new System.Drawing.Point(211, 211);
            this.userPassword_tBox.Margin = new System.Windows.Forms.Padding(5);
            this.userPassword_tBox.Name = "userPassword_tBox";
            this.userPassword_tBox.PasswordChar = '•';
            this.userPassword_tBox.Size = new System.Drawing.Size(225, 28);
            this.userPassword_tBox.TabIndex = 2;
            // 
            // rememberMe_cBox
            // 
            this.rememberMe_cBox.AutoSize = true;
            this.rememberMe_cBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rememberMe_cBox.Checked = true;
            this.rememberMe_cBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rememberMe_cBox.Location = new System.Drawing.Point(105, 249);
            this.rememberMe_cBox.Margin = new System.Windows.Forms.Padding(5);
            this.rememberMe_cBox.Name = "rememberMe_cBox";
            this.rememberMe_cBox.Size = new System.Drawing.Size(138, 24);
            this.rememberMe_cBox.TabIndex = 3;
            this.rememberMe_cBox.Text = "Remember Me";
            this.rememberMe_cBox.UseVisualStyleBackColor = true;
            // 
            // UserLogin_btn
            // 
            this.UserLogin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLogin_btn.Location = new System.Drawing.Point(284, 320);
            this.UserLogin_btn.Margin = new System.Windows.Forms.Padding(5);
            this.UserLogin_btn.Name = "UserLogin_btn";
            this.UserLogin_btn.Size = new System.Drawing.Size(152, 42);
            this.UserLogin_btn.TabIndex = 4;
            this.UserLogin_btn.Text = "Login";
            this.UserLogin_btn.UseVisualStyleBackColor = true;
            this.UserLogin_btn.Click += new System.EventHandler(this.UserLogin_btn_Click);
            // 
            // UserSignUp_btn
            // 
            this.UserSignUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSignUp_btn.Location = new System.Drawing.Point(105, 320);
            this.UserSignUp_btn.Margin = new System.Windows.Forms.Padding(5);
            this.UserSignUp_btn.Name = "UserSignUp_btn";
            this.UserSignUp_btn.Size = new System.Drawing.Size(152, 42);
            this.UserSignUp_btn.TabIndex = 5;
            this.UserSignUp_btn.Text = "Sign Up";
            this.UserSignUp_btn.UseVisualStyleBackColor = true;
            this.UserSignUp_btn.Click += new System.EventHandler(this.UserSignUp_btn_Click);
            // 
            // ForgotMyPass_btn
            // 
            this.ForgotMyPass_btn.FlatAppearance.BorderSize = 0;
            this.ForgotMyPass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotMyPass_btn.Font = new System.Drawing.Font("Myriad Pro Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotMyPass_btn.Location = new System.Drawing.Point(195, 381);
            this.ForgotMyPass_btn.Margin = new System.Windows.Forms.Padding(5);
            this.ForgotMyPass_btn.Name = "ForgotMyPass_btn";
            this.ForgotMyPass_btn.Size = new System.Drawing.Size(152, 39);
            this.ForgotMyPass_btn.TabIndex = 6;
            this.ForgotMyPass_btn.Text = "Forgot password?";
            this.ForgotMyPass_btn.UseVisualStyleBackColor = true;
            this.ForgotMyPass_btn.Click += new System.EventHandler(this.ForgotMyPass_btn_Click);
            // 
            // userGameName_label
            // 
            this.userGameName_label.AutoSize = true;
            this.userGameName_label.Location = new System.Drawing.Point(101, 162);
            this.userGameName_label.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.userGameName_label.Name = "userGameName_label";
            this.userGameName_label.Size = new System.Drawing.Size(82, 20);
            this.userGameName_label.TabIndex = 9;
            this.userGameName_label.Text = "Username";
            // 
            // userGameName_tBox
            // 
            this.userGameName_tBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            this.userGameName_tBox.Location = new System.Drawing.Point(211, 159);
            this.userGameName_tBox.Margin = new System.Windows.Forms.Padding(5);
            this.userGameName_tBox.Name = "userGameName_tBox";
            this.userGameName_tBox.Size = new System.Drawing.Size(225, 28);
            this.userGameName_tBox.TabIndex = 1;
            // 
            // exitGame_btn
            // 
            this.exitGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGame_btn.Location = new System.Drawing.Point(687, 394);
            this.exitGame_btn.Name = "exitGame_btn";
            this.exitGame_btn.Size = new System.Drawing.Size(101, 44);
            this.exitGame_btn.TabIndex = 11;
            this.exitGame_btn.Text = "Exit";
            this.exitGame_btn.UseVisualStyleBackColor = true;
            this.exitGame_btn.Click += new System.EventHandler(this.exitGame_btn_Click);
            // 
            // loginPanel
            // 
            this.loginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            this.loginPanel.Controls.Add(this.signupPanel);
            this.loginPanel.Controls.Add(this.rememberMe_cBox);
            this.loginPanel.Controls.Add(this.UserLogin_btn);
            this.loginPanel.Controls.Add(this.UserSignUp_btn);
            this.loginPanel.Controls.Add(this.ForgotMyPass_btn);
            this.loginPanel.Controls.Add(this.userPassword_tBox);
            this.loginPanel.Controls.Add(this.userGameName_label);
            this.loginPanel.Controls.Add(this.userGameName_tBox);
            this.loginPanel.Controls.Add(this.password_label);
            this.loginPanel.Controls.Add(this.label2);
            this.loginPanel.Location = new System.Drawing.Point(328, 0);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(530, 520);
            this.loginPanel.TabIndex = 10;
            // 
            // signupPanel
            // 
            this.signupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            this.signupPanel.Controls.Add(this.label1);
            this.signupPanel.Controls.Add(this.emailLabel);
            this.signupPanel.Controls.Add(this.lastNameLabel);
            this.signupPanel.Controls.Add(this.firstnameLabel);
            this.signupPanel.Controls.Add(this.passwordBox);
            this.signupPanel.Controls.Add(emailBox);
            this.signupPanel.Controls.Add(this.lastnameBox);
            this.signupPanel.Controls.Add(this.signupButton);
            this.signupPanel.Controls.Add(this.backButton);
            this.signupPanel.Controls.Add(this.firstnameBox);
            this.signupPanel.Controls.Add(this.usernameLabel);
            this.signupPanel.Controls.Add(this.usernameBox);
            this.signupPanel.Controls.Add(this.passwordLabel);
            this.signupPanel.Location = new System.Drawing.Point(0, -1);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(530, 520);
            this.signupPanel.TabIndex = 11;
            this.signupPanel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sign up";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(101, 295);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(52, 20);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "E-mail";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(101, 249);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(82, 20);
            this.lastNameLabel.TabIndex = 14;
            this.lastNameLabel.Text = "Last name";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Location = new System.Drawing.Point(101, 196);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(84, 20);
            this.firstnameLabel.TabIndex = 13;
            this.firstnameLabel.Text = "First name";
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            this.passwordBox.Location = new System.Drawing.Point(211, 341);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(5);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(225, 28);
            this.passwordBox.TabIndex = 12;
            // 
            // lastnameBox
            // 
            this.lastnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            this.lastnameBox.Location = new System.Drawing.Point(211, 244);
            this.lastnameBox.Margin = new System.Windows.Forms.Padding(5);
            this.lastnameBox.Name = "lastnameBox";
            this.lastnameBox.Size = new System.Drawing.Size(225, 28);
            this.lastnameBox.TabIndex = 10;
            // 
            // signupButton
            // 
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.ForeColor = System.Drawing.Color.LimeGreen;
            this.signupButton.Location = new System.Drawing.Point(284, 413);
            this.signupButton.Margin = new System.Windows.Forms.Padding(5);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(152, 42);
            this.signupButton.TabIndex = 4;
            this.signupButton.Text = "Create account";
            this.signupButton.UseVisualStyleBackColor = true;
            // 
            // backButton
            // 
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.ForeColor = System.Drawing.Color.Red;
            this.backButton.Location = new System.Drawing.Point(105, 413);
            this.backButton.Margin = new System.Windows.Forms.Padding(5);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(152, 42);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Go back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // firstnameBox
            // 
            this.firstnameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            this.firstnameBox.Location = new System.Drawing.Point(211, 193);
            this.firstnameBox.Margin = new System.Windows.Forms.Padding(5);
            this.firstnameBox.Name = "firstnameBox";
            this.firstnameBox.Size = new System.Drawing.Size(225, 28);
            this.firstnameBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(101, 144);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(82, 20);
            this.usernameLabel.TabIndex = 9;
            this.usernameLabel.Text = "Username";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(37)))), ((int)(((byte)(62)))));
            this.usernameBox.Location = new System.Drawing.Point(211, 141);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(5);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(225, 28);
            this.usernameBox.TabIndex = 1;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(101, 344);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(78, 20);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Myriad Pro", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 37);
            this.label2.TabIndex = 17;
            this.label2.Text = "Log in";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Verstoppertje_App.Properties.Resources.HSonline;
            this.pictureBox1.Location = new System.Drawing.Point(25, 178);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 147);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(37)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(856, 518);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Myriad Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(216)))), ((int)(((byte)(216)))));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "login_Page";
            this.Text = "Hide and Seek - Login";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userPassword_tBox;
        private System.Windows.Forms.CheckBox rememberMe_cBox;
        private System.Windows.Forms.Button UserLogin_btn;
        private System.Windows.Forms.Button UserSignUp_btn;
        private System.Windows.Forms.Button ForgotMyPass_btn;
        private System.Windows.Forms.Label userGameName_label;
        private System.Windows.Forms.TextBox userGameName_tBox;
        private System.Windows.Forms.Button exitGame_btn;
        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel signupPanel;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox firstnameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox lastnameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
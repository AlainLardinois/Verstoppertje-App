namespace Verstoppertje_App.Forms
{
    partial class LoginForm
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
            this.loginPanel = new System.Windows.Forms.Panel();
            this.passResetPanel = new System.Windows.Forms.Panel();
            this.passwordResetLabel = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.passResetButton = new System.Windows.Forms.Button();
            this.emailLabel = new System.Windows.Forms.Label();
            this.emailResetText = new System.Windows.Forms.TextBox();
            this.loginLabel = new System.Windows.Forms.Label();
            this.signupButton = new System.Windows.Forms.Button();
            this.forgotPasswordButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.userNameText = new System.Windows.Forms.TextBox();
            this.signupPanel = new System.Windows.Forms.Panel();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.newEmailLabel = new System.Windows.Forms.Label();
            this.newLastnameLabel = new System.Windows.Forms.Label();
            this.newFirstnameLabel = new System.Windows.Forms.Label();
            this.newPasswordText = new System.Windows.Forms.TextBox();
            this.newEmailText = new System.Windows.Forms.TextBox();
            this.newLastnameText = new System.Windows.Forms.TextBox();
            this.newFirstnameText = new System.Windows.Forms.TextBox();
            this.signupLabel = new System.Windows.Forms.Label();
            this.sBackButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.newUsernameLabel = new System.Windows.Forms.Label();
            this.newUsernameText = new System.Windows.Forms.TextBox();
            this.loginPanel.SuspendLayout();
            this.passResetPanel.SuspendLayout();
            this.signupPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginPanel
            // 
            this.loginPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginPanel.Controls.Add(this.passResetPanel);
            this.loginPanel.Controls.Add(this.loginLabel);
            this.loginPanel.Controls.Add(this.signupButton);
            this.loginPanel.Controls.Add(this.forgotPasswordButton);
            this.loginPanel.Controls.Add(this.loginButton);
            this.loginPanel.Controls.Add(this.passwordLabel);
            this.loginPanel.Controls.Add(this.userNameLabel);
            this.loginPanel.Controls.Add(this.passwordText);
            this.loginPanel.Controls.Add(this.userNameText);
            this.loginPanel.Location = new System.Drawing.Point(13, 13);
            this.loginPanel.Margin = new System.Windows.Forms.Padding(4);
            this.loginPanel.Name = "loginPanel";
            this.loginPanel.Size = new System.Drawing.Size(888, 480);
            this.loginPanel.TabIndex = 0;
            // 
            // passResetPanel
            // 
            this.passResetPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passResetPanel.Controls.Add(this.passwordResetLabel);
            this.passResetPanel.Controls.Add(this.backButton);
            this.passResetPanel.Controls.Add(this.passResetButton);
            this.passResetPanel.Controls.Add(this.emailLabel);
            this.passResetPanel.Controls.Add(this.emailResetText);
            this.passResetPanel.Location = new System.Drawing.Point(0, 0);
            this.passResetPanel.Margin = new System.Windows.Forms.Padding(4);
            this.passResetPanel.Name = "passResetPanel";
            this.passResetPanel.Size = new System.Drawing.Size(888, 480);
            this.passResetPanel.TabIndex = 8;
            this.passResetPanel.Visible = false;
            // 
            // passwordResetLabel
            // 
            this.passwordResetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordResetLabel.AutoSize = true;
            this.passwordResetLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordResetLabel.Location = new System.Drawing.Point(325, 116);
            this.passwordResetLabel.Name = "passwordResetLabel";
            this.passwordResetLabel.Size = new System.Drawing.Size(264, 41);
            this.passwordResetLabel.TabIndex = 7;
            this.passwordResetLabel.Text = "Reset password";
            // 
            // backButton
            // 
            this.backButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Montserrat Light", 8F);
            this.backButton.Location = new System.Drawing.Point(361, 324);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(192, 35);
            this.backButton.TabIndex = 5;
            this.backButton.Text = "Go back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // passResetButton
            // 
            this.passResetButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passResetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.passResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passResetButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.passResetButton.Location = new System.Drawing.Point(495, 259);
            this.passResetButton.Name = "passResetButton";
            this.passResetButton.Size = new System.Drawing.Size(112, 34);
            this.passResetButton.TabIndex = 4;
            this.passResetButton.Text = "Reset";
            this.passResetButton.UseVisualStyleBackColor = true;
            this.passResetButton.Click += new System.EventHandler(this.passResetButton_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(285, 207);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(66, 24);
            this.emailLabel.TabIndex = 2;
            this.emailLabel.Text = "E-mail";
            // 
            // emailResetText
            // 
            this.emailResetText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailResetText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.emailResetText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailResetText.ForeColor = System.Drawing.Color.Gainsboro;
            this.emailResetText.Location = new System.Drawing.Point(387, 205);
            this.emailResetText.Name = "emailResetText";
            this.emailResetText.Size = new System.Drawing.Size(220, 28);
            this.emailResetText.TabIndex = 0;
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginLabel.Location = new System.Drawing.Point(400, 71);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(114, 41);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Log in";
            // 
            // signupButton
            // 
            this.signupButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupButton.FlatAppearance.BorderSize = 0;
            this.signupButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.signupButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signupButton.Font = new System.Drawing.Font("Montserrat Light", 8F);
            this.signupButton.Location = new System.Drawing.Point(361, 365);
            this.signupButton.Name = "signupButton";
            this.signupButton.Size = new System.Drawing.Size(192, 35);
            this.signupButton.TabIndex = 6;
            this.signupButton.Text = "No account? Sign up";
            this.signupButton.UseVisualStyleBackColor = true;
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // forgotPasswordButton
            // 
            this.forgotPasswordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.forgotPasswordButton.FlatAppearance.BorderSize = 0;
            this.forgotPasswordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.forgotPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forgotPasswordButton.Font = new System.Drawing.Font("Montserrat Light", 8F);
            this.forgotPasswordButton.Location = new System.Drawing.Point(361, 324);
            this.forgotPasswordButton.Name = "forgotPasswordButton";
            this.forgotPasswordButton.Size = new System.Drawing.Size(192, 35);
            this.forgotPasswordButton.TabIndex = 5;
            this.forgotPasswordButton.Text = "Forgot password?";
            this.forgotPasswordButton.UseVisualStyleBackColor = true;
            this.forgotPasswordButton.Click += new System.EventHandler(this.forgotPasswordButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginButton.Location = new System.Drawing.Point(495, 259);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(112, 34);
            this.loginButton.TabIndex = 4;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(253, 208);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(93, 24);
            this.passwordLabel.TabIndex = 3;
            this.passwordLabel.Text = "Password";
            // 
            // userNameLabel
            // 
            this.userNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(253, 159);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(98, 24);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "Username";
            // 
            // passwordText
            // 
            this.passwordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.passwordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordText.ForeColor = System.Drawing.Color.Gainsboro;
            this.passwordText.Location = new System.Drawing.Point(387, 206);
            this.passwordText.Name = "passwordText";
            this.passwordText.PasswordChar = '•';
            this.passwordText.Size = new System.Drawing.Size(220, 28);
            this.passwordText.TabIndex = 1;
            // 
            // userNameText
            // 
            this.userNameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.userNameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userNameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.userNameText.Location = new System.Drawing.Point(387, 157);
            this.userNameText.Name = "userNameText";
            this.userNameText.Size = new System.Drawing.Size(220, 28);
            this.userNameText.TabIndex = 0;
            // 
            // signupPanel
            // 
            this.signupPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupPanel.Controls.Add(this.newPasswordLabel);
            this.signupPanel.Controls.Add(this.newEmailLabel);
            this.signupPanel.Controls.Add(this.newLastnameLabel);
            this.signupPanel.Controls.Add(this.newFirstnameLabel);
            this.signupPanel.Controls.Add(this.newPasswordText);
            this.signupPanel.Controls.Add(this.newEmailText);
            this.signupPanel.Controls.Add(this.newLastnameText);
            this.signupPanel.Controls.Add(this.newFirstnameText);
            this.signupPanel.Controls.Add(this.signupLabel);
            this.signupPanel.Controls.Add(this.sBackButton);
            this.signupPanel.Controls.Add(this.createButton);
            this.signupPanel.Controls.Add(this.newUsernameLabel);
            this.signupPanel.Controls.Add(this.newUsernameText);
            this.signupPanel.Location = new System.Drawing.Point(13, 13);
            this.signupPanel.Margin = new System.Windows.Forms.Padding(4);
            this.signupPanel.Name = "signupPanel";
            this.signupPanel.Size = new System.Drawing.Size(888, 480);
            this.signupPanel.TabIndex = 9;
            this.signupPanel.Visible = false;
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Location = new System.Drawing.Point(276, 276);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(93, 24);
            this.newPasswordLabel.TabIndex = 15;
            this.newPasswordLabel.Text = "Password";
            // 
            // newEmailLabel
            // 
            this.newEmailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newEmailLabel.AutoSize = true;
            this.newEmailLabel.Location = new System.Drawing.Point(276, 242);
            this.newEmailLabel.Name = "newEmailLabel";
            this.newEmailLabel.Size = new System.Drawing.Size(66, 24);
            this.newEmailLabel.TabIndex = 14;
            this.newEmailLabel.Text = "E-mail";
            // 
            // newLastnameLabel
            // 
            this.newLastnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newLastnameLabel.AutoSize = true;
            this.newLastnameLabel.Location = new System.Drawing.Point(276, 208);
            this.newLastnameLabel.Name = "newLastnameLabel";
            this.newLastnameLabel.Size = new System.Drawing.Size(99, 24);
            this.newLastnameLabel.TabIndex = 13;
            this.newLastnameLabel.Text = "Last name";
            // 
            // newFirstnameLabel
            // 
            this.newFirstnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newFirstnameLabel.AutoSize = true;
            this.newFirstnameLabel.Location = new System.Drawing.Point(276, 173);
            this.newFirstnameLabel.Name = "newFirstnameLabel";
            this.newFirstnameLabel.Size = new System.Drawing.Size(102, 24);
            this.newFirstnameLabel.TabIndex = 12;
            this.newFirstnameLabel.Text = "First name";
            // 
            // newPasswordText
            // 
            this.newPasswordText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.newPasswordText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newPasswordText.ForeColor = System.Drawing.Color.Gainsboro;
            this.newPasswordText.Location = new System.Drawing.Point(387, 274);
            this.newPasswordText.Name = "newPasswordText";
            this.newPasswordText.PasswordChar = '•';
            this.newPasswordText.Size = new System.Drawing.Size(220, 28);
            this.newPasswordText.TabIndex = 11;
            // 
            // newEmailText
            // 
            this.newEmailText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newEmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.newEmailText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newEmailText.ForeColor = System.Drawing.Color.Gainsboro;
            this.newEmailText.Location = new System.Drawing.Point(387, 240);
            this.newEmailText.Name = "newEmailText";
            this.newEmailText.Size = new System.Drawing.Size(220, 28);
            this.newEmailText.TabIndex = 10;
            // 
            // newLastnameText
            // 
            this.newLastnameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newLastnameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.newLastnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newLastnameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.newLastnameText.Location = new System.Drawing.Point(387, 205);
            this.newLastnameText.Name = "newLastnameText";
            this.newLastnameText.Size = new System.Drawing.Size(220, 28);
            this.newLastnameText.TabIndex = 9;
            // 
            // newFirstnameText
            // 
            this.newFirstnameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newFirstnameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.newFirstnameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newFirstnameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.newFirstnameText.Location = new System.Drawing.Point(387, 171);
            this.newFirstnameText.Name = "newFirstnameText";
            this.newFirstnameText.Size = new System.Drawing.Size(220, 28);
            this.newFirstnameText.TabIndex = 8;
            // 
            // signupLabel
            // 
            this.signupLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signupLabel.AutoSize = true;
            this.signupLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signupLabel.Location = new System.Drawing.Point(325, 63);
            this.signupLabel.Name = "signupLabel";
            this.signupLabel.Size = new System.Drawing.Size(254, 41);
            this.signupLabel.TabIndex = 7;
            this.signupLabel.Text = "Create account";
            // 
            // sBackButton
            // 
            this.sBackButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sBackButton.FlatAppearance.BorderSize = 0;
            this.sBackButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.sBackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sBackButton.Font = new System.Drawing.Font("Montserrat Light", 8F);
            this.sBackButton.Location = new System.Drawing.Point(361, 385);
            this.sBackButton.Name = "sBackButton";
            this.sBackButton.Size = new System.Drawing.Size(192, 35);
            this.sBackButton.TabIndex = 5;
            this.sBackButton.Text = "Go back";
            this.sBackButton.UseVisualStyleBackColor = true;
            this.sBackButton.Click += new System.EventHandler(this.sBackButton_Click);
            // 
            // createButton
            // 
            this.createButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.createButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.createButton.Location = new System.Drawing.Point(495, 322);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(112, 34);
            this.createButton.TabIndex = 4;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // newUsernameLabel
            // 
            this.newUsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newUsernameLabel.AutoSize = true;
            this.newUsernameLabel.Location = new System.Drawing.Point(276, 139);
            this.newUsernameLabel.Name = "newUsernameLabel";
            this.newUsernameLabel.Size = new System.Drawing.Size(98, 24);
            this.newUsernameLabel.TabIndex = 2;
            this.newUsernameLabel.Text = "Username";
            // 
            // newUsernameText
            // 
            this.newUsernameText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newUsernameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.newUsernameText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.newUsernameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.newUsernameText.Location = new System.Drawing.Point(387, 137);
            this.newUsernameText.Name = "newUsernameText";
            this.newUsernameText.Size = new System.Drawing.Size(220, 28);
            this.newUsernameText.TabIndex = 0;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.loginButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 506);
            this.Controls.Add(this.signupPanel);
            this.Controls.Add(this.loginPanel);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.loginPanel.ResumeLayout(false);
            this.loginPanel.PerformLayout();
            this.passResetPanel.ResumeLayout(false);
            this.passResetPanel.PerformLayout();
            this.signupPanel.ResumeLayout(false);
            this.signupPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel loginPanel;
        private System.Windows.Forms.TextBox userNameText;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.Button signupButton;
        private System.Windows.Forms.Button forgotPasswordButton;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Panel passResetPanel;
        private System.Windows.Forms.Label passwordResetLabel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button passResetButton;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailResetText;
        private System.Windows.Forms.Panel signupPanel;
        private System.Windows.Forms.Label signupLabel;
        private System.Windows.Forms.Button sBackButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label newUsernameLabel;
        private System.Windows.Forms.TextBox newUsernameText;
        private System.Windows.Forms.TextBox newPasswordText;
        private System.Windows.Forms.TextBox newEmailText;
        private System.Windows.Forms.TextBox newLastnameText;
        private System.Windows.Forms.TextBox newFirstnameText;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Label newEmailLabel;
        private System.Windows.Forms.Label newLastnameLabel;
        private System.Windows.Forms.Label newFirstnameLabel;
    }
}
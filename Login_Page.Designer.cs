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
            this.password_label = new System.Windows.Forms.Label();
            this.userPassword_tBox = new System.Windows.Forms.TextBox();
            this.rememberMe_cBox = new System.Windows.Forms.CheckBox();
            this.UserLogin_btn = new System.Windows.Forms.Button();
            this.UserSignUp_btn = new System.Windows.Forms.Button();
            this.ForgotMyPass_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userGameName_label = new System.Windows.Forms.Label();
            this.userGameName_tBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(35, 87);
            this.password_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(69, 17);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // userPassword_tBox
            // 
            this.userPassword_tBox.Location = new System.Drawing.Point(113, 84);
            this.userPassword_tBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userPassword_tBox.Name = "userPassword_tBox";
            this.userPassword_tBox.Size = new System.Drawing.Size(200, 22);
            this.userPassword_tBox.TabIndex = 2;
            // 
            // rememberMe_cBox
            // 
            this.rememberMe_cBox.AutoSize = true;
            this.rememberMe_cBox.Location = new System.Drawing.Point(113, 117);
            this.rememberMe_cBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rememberMe_cBox.Name = "rememberMe_cBox";
            this.rememberMe_cBox.Size = new System.Drawing.Size(122, 21);
            this.rememberMe_cBox.TabIndex = 3;
            this.rememberMe_cBox.Text = "Remember Me";
            this.rememberMe_cBox.UseVisualStyleBackColor = true;
            // 
            // UserLogin_btn
            // 
            this.UserLogin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLogin_btn.Location = new System.Drawing.Point(916, 359);
            this.UserLogin_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserLogin_btn.Name = "UserLogin_btn";
            this.UserLogin_btn.Size = new System.Drawing.Size(135, 54);
            this.UserLogin_btn.TabIndex = 4;
            this.UserLogin_btn.Text = "Login";
            this.UserLogin_btn.UseVisualStyleBackColor = true;
            this.UserLogin_btn.Click += new System.EventHandler(this.UserLogin_btn_Click);
            // 
            // UserSignUp_btn
            // 
            this.UserSignUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSignUp_btn.Location = new System.Drawing.Point(916, 421);
            this.UserSignUp_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UserSignUp_btn.Name = "UserSignUp_btn";
            this.UserSignUp_btn.Size = new System.Drawing.Size(135, 54);
            this.UserSignUp_btn.TabIndex = 5;
            this.UserSignUp_btn.Text = "Sign Up";
            this.UserSignUp_btn.UseVisualStyleBackColor = true;
            this.UserSignUp_btn.Click += new System.EventHandler(this.UserSignUp_btn_Click);
            // 
            // ForgotMyPass_btn
            // 
            this.ForgotMyPass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotMyPass_btn.Location = new System.Drawing.Point(916, 482);
            this.ForgotMyPass_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ForgotMyPass_btn.Name = "ForgotMyPass_btn";
            this.ForgotMyPass_btn.Size = new System.Drawing.Size(135, 54);
            this.ForgotMyPass_btn.TabIndex = 6;
            this.ForgotMyPass_btn.Text = "Forgot my Password";
            this.ForgotMyPass_btn.UseVisualStyleBackColor = true;
            this.ForgotMyPass_btn.Click += new System.EventHandler(this.ForgotMyPass_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(455, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(596, 320);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // userGameName_label
            // 
            this.userGameName_label.AutoSize = true;
            this.userGameName_label.Location = new System.Drawing.Point(17, 55);
            this.userGameName_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userGameName_label.Name = "userGameName_label";
            this.userGameName_label.Size = new System.Drawing.Size(87, 17);
            this.userGameName_label.TabIndex = 9;
            this.userGameName_label.Text = "Game Name";
            // 
            // userGameName_tBox
            // 
            this.userGameName_tBox.Location = new System.Drawing.Point(113, 52);
            this.userGameName_tBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userGameName_tBox.Name = "userGameName_tBox";
            this.userGameName_tBox.Size = new System.Drawing.Size(200, 22);
            this.userGameName_tBox.TabIndex = 1;
            // 
            // login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.userGameName_tBox);
            this.Controls.Add(this.userGameName_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ForgotMyPass_btn);
            this.Controls.Add(this.UserSignUp_btn);
            this.Controls.Add(this.UserLogin_btn);
            this.Controls.Add(this.rememberMe_cBox);
            this.Controls.Add(this.userPassword_tBox);
            this.Controls.Add(this.password_label);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "login_Page";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userPassword_tBox;
        private System.Windows.Forms.CheckBox rememberMe_cBox;
        private System.Windows.Forms.Button UserLogin_btn;
        private System.Windows.Forms.Button UserSignUp_btn;
        private System.Windows.Forms.Button ForgotMyPass_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userGameName_label;
        private System.Windows.Forms.TextBox userGameName_tBox;
    }
}
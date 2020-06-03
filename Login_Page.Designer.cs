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
            this.username_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.userName_tBox = new System.Windows.Forms.TextBox();
            this.userPassword_tBox = new System.Windows.Forms.TextBox();
            this.rememberMe_cBox = new System.Windows.Forms.CheckBox();
            this.UserLogin_btn = new System.Windows.Forms.Button();
            this.UserSignUp_btn = new System.Windows.Forms.Button();
            this.ForgotMyPass_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // username_label
            // 
            this.username_label.AutoSize = true;
            this.username_label.Location = new System.Drawing.Point(18, 41);
            this.username_label.Name = "username_label";
            this.username_label.Size = new System.Drawing.Size(55, 13);
            this.username_label.TabIndex = 0;
            this.username_label.Text = "Username";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(18, 71);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 13);
            this.password_label.TabIndex = 1;
            this.password_label.Text = "Password";
            // 
            // userName_tBox
            // 
            this.userName_tBox.Location = new System.Drawing.Point(85, 42);
            this.userName_tBox.Name = "userName_tBox";
            this.userName_tBox.Size = new System.Drawing.Size(100, 20);
            this.userName_tBox.TabIndex = 2;
            // 
            // userPassword_tBox
            // 
            this.userPassword_tBox.Location = new System.Drawing.Point(85, 68);
            this.userPassword_tBox.Name = "userPassword_tBox";
            this.userPassword_tBox.Size = new System.Drawing.Size(100, 20);
            this.userPassword_tBox.TabIndex = 3;
            // 
            // rememberMe_cBox
            // 
            this.rememberMe_cBox.AutoSize = true;
            this.rememberMe_cBox.Location = new System.Drawing.Point(85, 95);
            this.rememberMe_cBox.Name = "rememberMe_cBox";
            this.rememberMe_cBox.Size = new System.Drawing.Size(95, 17);
            this.rememberMe_cBox.TabIndex = 4;
            this.rememberMe_cBox.Text = "Remember Me";
            this.rememberMe_cBox.UseVisualStyleBackColor = true;
            // 
            // UserLogin_btn
            // 
            this.UserLogin_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserLogin_btn.Location = new System.Drawing.Point(687, 292);
            this.UserLogin_btn.Name = "UserLogin_btn";
            this.UserLogin_btn.Size = new System.Drawing.Size(101, 44);
            this.UserLogin_btn.TabIndex = 5;
            this.UserLogin_btn.Text = "Login";
            this.UserLogin_btn.UseVisualStyleBackColor = true;
            this.UserLogin_btn.Click += new System.EventHandler(this.UserLogin_btn_Click);
            // 
            // UserSignUp_btn
            // 
            this.UserSignUp_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserSignUp_btn.Location = new System.Drawing.Point(687, 342);
            this.UserSignUp_btn.Name = "UserSignUp_btn";
            this.UserSignUp_btn.Size = new System.Drawing.Size(101, 44);
            this.UserSignUp_btn.TabIndex = 6;
            this.UserSignUp_btn.Text = "Sign Up";
            this.UserSignUp_btn.UseVisualStyleBackColor = true;
            this.UserSignUp_btn.Click += new System.EventHandler(this.UserSignUp_btn_Click);
            // 
            // ForgotMyPass_btn
            // 
            this.ForgotMyPass_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ForgotMyPass_btn.Location = new System.Drawing.Point(687, 392);
            this.ForgotMyPass_btn.Name = "ForgotMyPass_btn";
            this.ForgotMyPass_btn.Size = new System.Drawing.Size(101, 44);
            this.ForgotMyPass_btn.TabIndex = 7;
            this.ForgotMyPass_btn.Text = "Forgot my Password";
            this.ForgotMyPass_btn.UseVisualStyleBackColor = true;
            this.ForgotMyPass_btn.Click += new System.EventHandler(this.ForgotMyPass_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(341, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(447, 260);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ForgotMyPass_btn);
            this.Controls.Add(this.UserSignUp_btn);
            this.Controls.Add(this.UserLogin_btn);
            this.Controls.Add(this.rememberMe_cBox);
            this.Controls.Add(this.userPassword_tBox);
            this.Controls.Add(this.userName_tBox);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.username_label);
            this.Name = "login_Page";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label username_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.TextBox userName_tBox;
        private System.Windows.Forms.TextBox userPassword_tBox;
        private System.Windows.Forms.CheckBox rememberMe_cBox;
        private System.Windows.Forms.Button UserLogin_btn;
        private System.Windows.Forms.Button UserSignUp_btn;
        private System.Windows.Forms.Button ForgotMyPass_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
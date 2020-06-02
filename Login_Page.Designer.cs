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
            this.userLogin_btn = new System.Windows.Forms.Button();
            this.userRegister_btn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.rememberMe_CBox = new System.Windows.Forms.CheckBox();
            this.userName_label = new System.Windows.Forms.Label();
            this.passWord_label = new System.Windows.Forms.Label();
            this.passwordReset_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userLogin_btn
            // 
            this.userLogin_btn.Location = new System.Drawing.Point(290, 121);
            this.userLogin_btn.Name = "userLogin_btn";
            this.userLogin_btn.Size = new System.Drawing.Size(112, 23);
            this.userLogin_btn.TabIndex = 0;
            this.userLogin_btn.Text = "Login";
            this.userLogin_btn.UseVisualStyleBackColor = true;
            // 
            // userRegister_btn
            // 
            this.userRegister_btn.Location = new System.Drawing.Point(290, 150);
            this.userRegister_btn.Name = "userRegister_btn";
            this.userRegister_btn.Size = new System.Drawing.Size(112, 23);
            this.userRegister_btn.TabIndex = 1;
            this.userRegister_btn.Text = "Sign Up";
            this.userRegister_btn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(72, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 3;
            // 
            // rememberMe_CBox
            // 
            this.rememberMe_CBox.AutoSize = true;
            this.rememberMe_CBox.Location = new System.Drawing.Point(72, 82);
            this.rememberMe_CBox.Name = "rememberMe_CBox";
            this.rememberMe_CBox.Size = new System.Drawing.Size(95, 17);
            this.rememberMe_CBox.TabIndex = 4;
            this.rememberMe_CBox.Text = "Remember Me";
            this.rememberMe_CBox.UseVisualStyleBackColor = true;
            // 
            // userName_label
            // 
            this.userName_label.AutoSize = true;
            this.userName_label.Location = new System.Drawing.Point(11, 33);
            this.userName_label.Name = "userName_label";
            this.userName_label.Size = new System.Drawing.Size(55, 13);
            this.userName_label.TabIndex = 5;
            this.userName_label.Text = "Username";
            // 
            // passWord_label
            // 
            this.passWord_label.AutoSize = true;
            this.passWord_label.Location = new System.Drawing.Point(13, 59);
            this.passWord_label.Name = "passWord_label";
            this.passWord_label.Size = new System.Drawing.Size(53, 13);
            this.passWord_label.TabIndex = 6;
            this.passWord_label.Text = "Password";
            // 
            // passwordReset_btn
            // 
            this.passwordReset_btn.Location = new System.Drawing.Point(290, 179);
            this.passwordReset_btn.Name = "passwordReset_btn";
            this.passwordReset_btn.Size = new System.Drawing.Size(112, 23);
            this.passwordReset_btn.TabIndex = 7;
            this.passwordReset_btn.Text = "Forgot my Password";
            this.passwordReset_btn.UseVisualStyleBackColor = true;
            // 
            // login_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 214);
            this.Controls.Add(this.passwordReset_btn);
            this.Controls.Add(this.passWord_label);
            this.Controls.Add(this.userName_label);
            this.Controls.Add(this.rememberMe_CBox);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.userRegister_btn);
            this.Controls.Add(this.userLogin_btn);
            this.Name = "login_Page";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button userLogin_btn;
        private System.Windows.Forms.Button userRegister_btn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox rememberMe_CBox;
        private System.Windows.Forms.Label userName_label;
        private System.Windows.Forms.Label passWord_label;
        private System.Windows.Forms.Button passwordReset_btn;
    }
}


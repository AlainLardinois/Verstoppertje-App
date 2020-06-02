namespace Verstoppertje_App
{
    partial class signUp_Page
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
            this.signUp_btn = new System.Windows.Forms.Button();
            this.userName_textBox = new System.Windows.Forms.TextBox();
            this.userName_Label = new System.Windows.Forms.Label();
            this.userGameName_label = new System.Windows.Forms.Label();
            this.userGameName_textBox = new System.Windows.Forms.TextBox();
            this.userPassword_label = new System.Windows.Forms.Label();
            this.userEmail_label = new System.Windows.Forms.Label();
            this.userPassword_textBox = new System.Windows.Forms.TextBox();
            this.userEmail_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signUp_btn
            // 
            this.signUp_btn.Location = new System.Drawing.Point(269, 165);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(93, 42);
            this.signUp_btn.TabIndex = 0;
            this.signUp_btn.Text = "Sign up";
            this.signUp_btn.UseVisualStyleBackColor = true;
            // 
            // userName_textBox
            // 
            this.userName_textBox.Location = new System.Drawing.Point(87, 63);
            this.userName_textBox.Name = "userName_textBox";
            this.userName_textBox.Size = new System.Drawing.Size(165, 20);
            this.userName_textBox.TabIndex = 1;
            // 
            // userName_Label
            // 
            this.userName_Label.AutoSize = true;
            this.userName_Label.Location = new System.Drawing.Point(15, 66);
            this.userName_Label.Name = "userName_Label";
            this.userName_Label.Size = new System.Drawing.Size(55, 13);
            this.userName_Label.TabIndex = 2;
            this.userName_Label.Text = "Username";
            // 
            // userGameName_label
            // 
            this.userGameName_label.AutoSize = true;
            this.userGameName_label.Location = new System.Drawing.Point(15, 40);
            this.userGameName_label.Name = "userGameName_label";
            this.userGameName_label.Size = new System.Drawing.Size(66, 13);
            this.userGameName_label.TabIndex = 3;
            this.userGameName_label.Text = "Game Name";
            // 
            // userGameName_textBox
            // 
            this.userGameName_textBox.Location = new System.Drawing.Point(87, 37);
            this.userGameName_textBox.Name = "userGameName_textBox";
            this.userGameName_textBox.Size = new System.Drawing.Size(165, 20);
            this.userGameName_textBox.TabIndex = 4;
            // 
            // userPassword_label
            // 
            this.userPassword_label.AutoSize = true;
            this.userPassword_label.Location = new System.Drawing.Point(15, 89);
            this.userPassword_label.Name = "userPassword_label";
            this.userPassword_label.Size = new System.Drawing.Size(53, 13);
            this.userPassword_label.TabIndex = 5;
            this.userPassword_label.Text = "Password";
            // 
            // userEmail_label
            // 
            this.userEmail_label.AutoSize = true;
            this.userEmail_label.Location = new System.Drawing.Point(15, 116);
            this.userEmail_label.Name = "userEmail_label";
            this.userEmail_label.Size = new System.Drawing.Size(32, 13);
            this.userEmail_label.TabIndex = 6;
            this.userEmail_label.Text = "Email";
            // 
            // userPassword_textBox
            // 
            this.userPassword_textBox.Location = new System.Drawing.Point(87, 89);
            this.userPassword_textBox.Name = "userPassword_textBox";
            this.userPassword_textBox.Size = new System.Drawing.Size(165, 20);
            this.userPassword_textBox.TabIndex = 7;
            // 
            // userEmail_textBox
            // 
            this.userEmail_textBox.Location = new System.Drawing.Point(87, 116);
            this.userEmail_textBox.Name = "userEmail_textBox";
            this.userEmail_textBox.Size = new System.Drawing.Size(165, 20);
            this.userEmail_textBox.TabIndex = 8;
            // 
            // signUp_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 219);
            this.Controls.Add(this.userEmail_textBox);
            this.Controls.Add(this.userPassword_textBox);
            this.Controls.Add(this.userEmail_label);
            this.Controls.Add(this.userPassword_label);
            this.Controls.Add(this.userGameName_textBox);
            this.Controls.Add(this.userGameName_label);
            this.Controls.Add(this.userName_Label);
            this.Controls.Add(this.userName_textBox);
            this.Controls.Add(this.signUp_btn);
            this.Name = "signUp_Page";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.TextBox userName_textBox;
        private System.Windows.Forms.Label userName_Label;
        private System.Windows.Forms.Label userGameName_label;
        private System.Windows.Forms.TextBox userGameName_textBox;
        private System.Windows.Forms.Label userPassword_label;
        private System.Windows.Forms.Label userEmail_label;
        private System.Windows.Forms.TextBox userPassword_textBox;
        private System.Windows.Forms.TextBox userEmail_textBox;
    }
}
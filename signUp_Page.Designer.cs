﻿namespace Verstoppertje_App
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
            this.userGameName_label = new System.Windows.Forms.Label();
            this.userGameName_tBox = new System.Windows.Forms.TextBox();
            this.userPassword_label = new System.Windows.Forms.Label();
            this.userEmail_label = new System.Windows.Forms.Label();
            this.userPassword_tBox = new System.Windows.Forms.TextBox();
            this.userEmail_tBox = new System.Windows.Forms.TextBox();
            this.exitMenu_btn = new System.Windows.Forms.Button();
            this.firstName_label = new System.Windows.Forms.Label();
            this.lastName_label = new System.Windows.Forms.Label();
            this.userFirstName_tBox = new System.Windows.Forms.TextBox();
            this.userLastName_tBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // signUp_btn
            // 
            this.signUp_btn.Location = new System.Drawing.Point(408, 204);
            this.signUp_btn.Name = "signUp_btn";
            this.signUp_btn.Size = new System.Drawing.Size(93, 42);
            this.signUp_btn.TabIndex = 0;
            this.signUp_btn.Text = "Sign up";
            this.signUp_btn.UseVisualStyleBackColor = true;
            this.signUp_btn.Click += new System.EventHandler(this.signUp_btn_Click);
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
            // userGameName_tBox
            // 
            this.userGameName_tBox.Location = new System.Drawing.Point(87, 37);
            this.userGameName_tBox.Name = "userGameName_tBox";
            this.userGameName_tBox.Size = new System.Drawing.Size(165, 20);
            this.userGameName_tBox.TabIndex = 4;
            // 
            // userPassword_label
            // 
            this.userPassword_label.AutoSize = true;
            this.userPassword_label.Location = new System.Drawing.Point(28, 118);
            this.userPassword_label.Name = "userPassword_label";
            this.userPassword_label.Size = new System.Drawing.Size(53, 13);
            this.userPassword_label.TabIndex = 5;
            this.userPassword_label.Text = "Password";
            // 
            // userEmail_label
            // 
            this.userEmail_label.AutoSize = true;
            this.userEmail_label.Location = new System.Drawing.Point(49, 141);
            this.userEmail_label.Name = "userEmail_label";
            this.userEmail_label.Size = new System.Drawing.Size(32, 13);
            this.userEmail_label.TabIndex = 6;
            this.userEmail_label.Text = "Email";
            // 
            // userPassword_tBox
            // 
            this.userPassword_tBox.Location = new System.Drawing.Point(87, 115);
            this.userPassword_tBox.Name = "userPassword_tBox";
            this.userPassword_tBox.Size = new System.Drawing.Size(165, 20);
            this.userPassword_tBox.TabIndex = 7;
            // 
            // userEmail_tBox
            // 
            this.userEmail_tBox.Location = new System.Drawing.Point(87, 141);
            this.userEmail_tBox.Name = "userEmail_tBox";
            this.userEmail_tBox.Size = new System.Drawing.Size(165, 20);
            this.userEmail_tBox.TabIndex = 8;
            // 
            // exitMenu_btn
            // 
            this.exitMenu_btn.Location = new System.Drawing.Point(309, 204);
            this.exitMenu_btn.Name = "exitMenu_btn";
            this.exitMenu_btn.Size = new System.Drawing.Size(93, 42);
            this.exitMenu_btn.TabIndex = 9;
            this.exitMenu_btn.Text = "Exit";
            this.exitMenu_btn.UseVisualStyleBackColor = true;
            this.exitMenu_btn.Click += new System.EventHandler(this.exitMenu_btn_Click);
            // 
            // firstName_label
            // 
            this.firstName_label.AutoSize = true;
            this.firstName_label.Location = new System.Drawing.Point(24, 66);
            this.firstName_label.Name = "firstName_label";
            this.firstName_label.Size = new System.Drawing.Size(57, 13);
            this.firstName_label.TabIndex = 10;
            this.firstName_label.Text = "First Name";
            // 
            // lastName_label
            // 
            this.lastName_label.AutoSize = true;
            this.lastName_label.Location = new System.Drawing.Point(23, 92);
            this.lastName_label.Name = "lastName_label";
            this.lastName_label.Size = new System.Drawing.Size(58, 13);
            this.lastName_label.TabIndex = 11;
            this.lastName_label.Text = "Last Name";
            // 
            // userFirstName_tBox
            // 
            this.userFirstName_tBox.Location = new System.Drawing.Point(87, 63);
            this.userFirstName_tBox.Name = "userFirstName_tBox";
            this.userFirstName_tBox.Size = new System.Drawing.Size(165, 20);
            this.userFirstName_tBox.TabIndex = 12;
            // 
            // userLastName_tBox
            // 
            this.userLastName_tBox.Location = new System.Drawing.Point(87, 89);
            this.userLastName_tBox.Name = "userLastName_tBox";
            this.userLastName_tBox.Size = new System.Drawing.Size(165, 20);
            this.userLastName_tBox.TabIndex = 13;
            // 
            // signUp_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 258);
            this.Controls.Add(this.userLastName_tBox);
            this.Controls.Add(this.userFirstName_tBox);
            this.Controls.Add(this.lastName_label);
            this.Controls.Add(this.firstName_label);
            this.Controls.Add(this.exitMenu_btn);
            this.Controls.Add(this.userEmail_tBox);
            this.Controls.Add(this.userPassword_tBox);
            this.Controls.Add(this.userEmail_label);
            this.Controls.Add(this.userPassword_label);
            this.Controls.Add(this.userGameName_tBox);
            this.Controls.Add(this.userGameName_label);
            this.Controls.Add(this.signUp_btn);
            this.Name = "signUp_Page";
            this.Text = "Sign Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUp_btn;
        private System.Windows.Forms.Label userGameName_label;
        private System.Windows.Forms.TextBox userGameName_tBox;
        private System.Windows.Forms.Label userPassword_label;
        private System.Windows.Forms.Label userEmail_label;
        private System.Windows.Forms.TextBox userPassword_tBox;
        private System.Windows.Forms.TextBox userEmail_tBox;
        private System.Windows.Forms.Button exitMenu_btn;
        private System.Windows.Forms.Label firstName_label;
        private System.Windows.Forms.Label lastName_label;
        private System.Windows.Forms.TextBox userFirstName_tBox;
        private System.Windows.Forms.TextBox userLastName_tBox;
    }
}
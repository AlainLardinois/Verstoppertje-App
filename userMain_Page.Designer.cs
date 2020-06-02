namespace Verstoppertje_App
{
    partial class userMain_Page
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
            this.userWelcome_RTextBox = new System.Windows.Forms.RichTextBox();
            this.playGame_btn = new System.Windows.Forms.Button();
            this.exitGame_btn = new System.Windows.Forms.Button();
            this.itemShop_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userWelcome_RTextBox
            // 
            this.userWelcome_RTextBox.Location = new System.Drawing.Point(617, 30);
            this.userWelcome_RTextBox.Name = "userWelcome_RTextBox";
            this.userWelcome_RTextBox.Size = new System.Drawing.Size(171, 82);
            this.userWelcome_RTextBox.TabIndex = 0;
            this.userWelcome_RTextBox.Text = "Welcome to the online edition of \n\nHide & Seek\n\nEnjoy.";
            // 
            // playGame_btn
            // 
            this.playGame_btn.Location = new System.Drawing.Point(23, 33);
            this.playGame_btn.Name = "playGame_btn";
            this.playGame_btn.Size = new System.Drawing.Size(100, 47);
            this.playGame_btn.TabIndex = 1;
            this.playGame_btn.Text = "Play Game";
            this.playGame_btn.UseVisualStyleBackColor = true;
            // 
            // exitGame_btn
            // 
            this.exitGame_btn.Location = new System.Drawing.Point(684, 388);
            this.exitGame_btn.Name = "exitGame_btn";
            this.exitGame_btn.Size = new System.Drawing.Size(104, 50);
            this.exitGame_btn.TabIndex = 2;
            this.exitGame_btn.Text = "Exit Game";
            this.exitGame_btn.UseVisualStyleBackColor = true;
            // 
            // itemShop_btn
            // 
            this.itemShop_btn.Location = new System.Drawing.Point(23, 86);
            this.itemShop_btn.Name = "itemShop_btn";
            this.itemShop_btn.Size = new System.Drawing.Size(100, 47);
            this.itemShop_btn.TabIndex = 3;
            this.itemShop_btn.Text = "Shop";
            this.itemShop_btn.UseVisualStyleBackColor = true;
            // 
            // userMain_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.itemShop_btn);
            this.Controls.Add(this.exitGame_btn);
            this.Controls.Add(this.playGame_btn);
            this.Controls.Add(this.userWelcome_RTextBox);
            this.Name = "userMain_Page";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox userWelcome_RTextBox;
        private System.Windows.Forms.Button playGame_btn;
        private System.Windows.Forms.Button exitGame_btn;
        private System.Windows.Forms.Button itemShop_btn;
    }
}
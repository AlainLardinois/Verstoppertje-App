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
            this.leaderBord_btn = new System.Windows.Forms.Button();
            this.myProfile_btn = new System.Windows.Forms.Button();
            this.leaderBord_dGView = new System.Windows.Forms.DataGridView();
            this.userScore_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.leaderBord_dGView)).BeginInit();
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
            this.playGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playGame_btn.Location = new System.Drawing.Point(23, 29);
            this.playGame_btn.Name = "playGame_btn";
            this.playGame_btn.Size = new System.Drawing.Size(100, 47);
            this.playGame_btn.TabIndex = 1;
            this.playGame_btn.Text = "Play Game";
            this.playGame_btn.UseVisualStyleBackColor = true;
            this.playGame_btn.Click += new System.EventHandler(this.playGame_btn_Click);
            // 
            // exitGame_btn
            // 
            this.exitGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitGame_btn.Location = new System.Drawing.Point(684, 388);
            this.exitGame_btn.Name = "exitGame_btn";
            this.exitGame_btn.Size = new System.Drawing.Size(104, 50);
            this.exitGame_btn.TabIndex = 2;
            this.exitGame_btn.Text = "Exit Game";
            this.exitGame_btn.UseVisualStyleBackColor = true;
            this.exitGame_btn.Click += new System.EventHandler(this.exitGame_btn_Click);
            // 
            // itemShop_btn
            // 
            this.itemShop_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemShop_btn.Location = new System.Drawing.Point(23, 82);
            this.itemShop_btn.Name = "itemShop_btn";
            this.itemShop_btn.Size = new System.Drawing.Size(100, 47);
            this.itemShop_btn.TabIndex = 3;
            this.itemShop_btn.Text = "Shop";
            this.itemShop_btn.UseVisualStyleBackColor = true;
            this.itemShop_btn.Click += new System.EventHandler(this.itemShop_btn_Click);
            // 
            // leaderBord_btn
            // 
            this.leaderBord_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.leaderBord_btn.Location = new System.Drawing.Point(499, 243);
            this.leaderBord_btn.Name = "leaderBord_btn";
            this.leaderBord_btn.Size = new System.Drawing.Size(75, 23);
            this.leaderBord_btn.TabIndex = 5;
            this.leaderBord_btn.Text = "Leaderbord";
            this.leaderBord_btn.UseVisualStyleBackColor = true;
            // 
            // myProfile_btn
            // 
            this.myProfile_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.myProfile_btn.Location = new System.Drawing.Point(23, 135);
            this.myProfile_btn.Name = "myProfile_btn";
            this.myProfile_btn.Size = new System.Drawing.Size(100, 47);
            this.myProfile_btn.TabIndex = 6;
            this.myProfile_btn.Text = "My Profile";
            this.myProfile_btn.UseVisualStyleBackColor = true;
            this.myProfile_btn.Click += new System.EventHandler(this.myProfile_btn_Click);
            // 
            // leaderBord_dGView
            // 
            this.leaderBord_dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.leaderBord_dGView.Location = new System.Drawing.Point(187, 29);
            this.leaderBord_dGView.Name = "leaderBord_dGView";
            this.leaderBord_dGView.Size = new System.Drawing.Size(391, 206);
            this.leaderBord_dGView.TabIndex = 7;
            // 
            // userScore_btn
            // 
            this.userScore_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userScore_btn.Location = new System.Drawing.Point(418, 243);
            this.userScore_btn.Name = "userScore_btn";
            this.userScore_btn.Size = new System.Drawing.Size(75, 23);
            this.userScore_btn.TabIndex = 8;
            this.userScore_btn.Text = "My Score";
            this.userScore_btn.UseVisualStyleBackColor = true;
            // 
            // userMain_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.userScore_btn);
            this.Controls.Add(this.leaderBord_dGView);
            this.Controls.Add(this.myProfile_btn);
            this.Controls.Add(this.leaderBord_btn);
            this.Controls.Add(this.itemShop_btn);
            this.Controls.Add(this.exitGame_btn);
            this.Controls.Add(this.playGame_btn);
            this.Controls.Add(this.userWelcome_RTextBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "userMain_Page";
            this.Text = "Main Menu";
            ((System.ComponentModel.ISupportInitialize)(this.leaderBord_dGView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox userWelcome_RTextBox;
        private System.Windows.Forms.Button playGame_btn;
        private System.Windows.Forms.Button exitGame_btn;
        private System.Windows.Forms.Button itemShop_btn;
        private System.Windows.Forms.Button leaderBord_btn;
        private System.Windows.Forms.Button myProfile_btn;
        private System.Windows.Forms.DataGridView leaderBord_dGView;
        private System.Windows.Forms.Button userScore_btn;
    }
}
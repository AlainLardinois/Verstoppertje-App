namespace Verstoppertje_App.Forms
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.helpTabs = new System.Windows.Forms.TabControl();
            this.gameTab = new System.Windows.Forms.TabPage();
            this.gameText = new System.Windows.Forms.RichTextBox();
            this.shopTab = new System.Windows.Forms.TabPage();
            this.shopText = new System.Windows.Forms.RichTextBox();
            this.loginTab = new System.Windows.Forms.TabPage();
            this.loginText = new System.Windows.Forms.RichTextBox();
            this.profileTab = new System.Windows.Forms.TabPage();
            this.profileText = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.helpTabs.SuspendLayout();
            this.gameTab.SuspendLayout();
            this.shopTab.SuspendLayout();
            this.loginTab.SuspendLayout();
            this.profileTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.helpTabs);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(890, 482);
            this.panel1.TabIndex = 0;
            // 
            // helpTabs
            // 
            this.helpTabs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.helpTabs.Controls.Add(this.gameTab);
            this.helpTabs.Controls.Add(this.shopTab);
            this.helpTabs.Controls.Add(this.loginTab);
            this.helpTabs.Controls.Add(this.profileTab);
            this.helpTabs.Location = new System.Drawing.Point(16, 14);
            this.helpTabs.Name = "helpTabs";
            this.helpTabs.SelectedIndex = 0;
            this.helpTabs.Size = new System.Drawing.Size(857, 454);
            this.helpTabs.TabIndex = 0;
            // 
            // gameTab
            // 
            this.gameTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gameTab.Controls.Add(this.gameText);
            this.gameTab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gameTab.Location = new System.Drawing.Point(4, 33);
            this.gameTab.Name = "gameTab";
            this.gameTab.Padding = new System.Windows.Forms.Padding(3);
            this.gameTab.Size = new System.Drawing.Size(849, 417);
            this.gameTab.TabIndex = 0;
            this.gameTab.Text = "Game";
            // 
            // gameText
            // 
            this.gameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.gameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gameText.ForeColor = System.Drawing.Color.Gainsboro;
            this.gameText.Location = new System.Drawing.Point(6, 6);
            this.gameText.Name = "gameText";
            this.gameText.Size = new System.Drawing.Size(837, 405);
            this.gameText.TabIndex = 0;
            this.gameText.Text = resources.GetString("gameText.Text");
            // 
            // shopTab
            // 
            this.shopTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.shopTab.Controls.Add(this.shopText);
            this.shopTab.Location = new System.Drawing.Point(4, 33);
            this.shopTab.Name = "shopTab";
            this.shopTab.Padding = new System.Windows.Forms.Padding(3);
            this.shopTab.Size = new System.Drawing.Size(849, 417);
            this.shopTab.TabIndex = 1;
            this.shopTab.Text = "Shop";
            // 
            // shopText
            // 
            this.shopText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.shopText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shopText.ForeColor = System.Drawing.Color.Gainsboro;
            this.shopText.Location = new System.Drawing.Point(6, 6);
            this.shopText.Name = "shopText";
            this.shopText.Size = new System.Drawing.Size(837, 405);
            this.shopText.TabIndex = 1;
            this.shopText.Text = resources.GetString("shopText.Text");
            // 
            // loginTab
            // 
            this.loginTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.loginTab.Controls.Add(this.loginText);
            this.loginTab.Location = new System.Drawing.Point(4, 33);
            this.loginTab.Name = "loginTab";
            this.loginTab.Padding = new System.Windows.Forms.Padding(3);
            this.loginTab.Size = new System.Drawing.Size(849, 417);
            this.loginTab.TabIndex = 2;
            this.loginTab.Text = "Account";
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.loginText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginText.ForeColor = System.Drawing.Color.Gainsboro;
            this.loginText.Location = new System.Drawing.Point(6, 6);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(837, 405);
            this.loginText.TabIndex = 2;
            this.loginText.Text = resources.GetString("loginText.Text");
            // 
            // profileTab
            // 
            this.profileTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.profileTab.Controls.Add(this.profileText);
            this.profileTab.Location = new System.Drawing.Point(4, 33);
            this.profileTab.Name = "profileTab";
            this.profileTab.Padding = new System.Windows.Forms.Padding(3);
            this.profileTab.Size = new System.Drawing.Size(849, 417);
            this.profileTab.TabIndex = 3;
            this.profileTab.Text = "Profile";
            // 
            // profileText
            // 
            this.profileText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.profileText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.profileText.ForeColor = System.Drawing.Color.Gainsboro;
            this.profileText.Location = new System.Drawing.Point(6, 6);
            this.profileText.Name = "profileText";
            this.profileText.Size = new System.Drawing.Size(837, 405);
            this.profileText.TabIndex = 2;
            this.profileText.Text = resources.GetString("profileText.Text");
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 506);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HelpForm";
            this.Text = "HelpForm";
            this.panel1.ResumeLayout(false);
            this.helpTabs.ResumeLayout(false);
            this.gameTab.ResumeLayout(false);
            this.shopTab.ResumeLayout(false);
            this.loginTab.ResumeLayout(false);
            this.profileTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl helpTabs;
        private System.Windows.Forms.TabPage gameTab;
        private System.Windows.Forms.TabPage shopTab;
        private System.Windows.Forms.TabPage loginTab;
        private System.Windows.Forms.TabPage profileTab;
        private System.Windows.Forms.RichTextBox gameText;
        private System.Windows.Forms.RichTextBox shopText;
        private System.Windows.Forms.RichTextBox loginText;
        private System.Windows.Forms.RichTextBox profileText;
    }
}
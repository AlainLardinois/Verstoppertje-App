namespace Verstoppertje_App
{
    partial class gameSettings_Page
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
            this.gameTime_comboBox = new System.Windows.Forms.ComboBox();
            this.gameTime_label = new System.Windows.Forms.Label();
            this.hideTime_label = new System.Windows.Forms.Label();
            this.hidingTime_comboBox = new System.Windows.Forms.ComboBox();
            this.difficulty_label = new System.Windows.Forms.Label();
            this.difficulty_comboBox = new System.Windows.Forms.ComboBox();
            this.returnMain_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.startGame_btn = new System.Windows.Forms.Button();
            this.stopGame_btn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // gameTime_comboBox
            // 
            this.gameTime_comboBox.FormattingEnabled = true;
            this.gameTime_comboBox.Location = new System.Drawing.Point(82, 47);
            this.gameTime_comboBox.Name = "gameTime_comboBox";
            this.gameTime_comboBox.Size = new System.Drawing.Size(121, 21);
            this.gameTime_comboBox.TabIndex = 0;
            // 
            // gameTime_label
            // 
            this.gameTime_label.AutoSize = true;
            this.gameTime_label.Location = new System.Drawing.Point(12, 50);
            this.gameTime_label.Name = "gameTime_label";
            this.gameTime_label.Size = new System.Drawing.Size(61, 13);
            this.gameTime_label.TabIndex = 1;
            this.gameTime_label.Text = "Game Time";
            // 
            // hideTime_label
            // 
            this.hideTime_label.AutoSize = true;
            this.hideTime_label.Location = new System.Drawing.Point(12, 86);
            this.hideTime_label.Name = "hideTime_label";
            this.hideTime_label.Size = new System.Drawing.Size(63, 13);
            this.hideTime_label.TabIndex = 2;
            this.hideTime_label.Text = "Hiding Time";
            // 
            // hidingTime_comboBox
            // 
            this.hidingTime_comboBox.FormattingEnabled = true;
            this.hidingTime_comboBox.Location = new System.Drawing.Point(82, 86);
            this.hidingTime_comboBox.Name = "hidingTime_comboBox";
            this.hidingTime_comboBox.Size = new System.Drawing.Size(121, 21);
            this.hidingTime_comboBox.TabIndex = 3;
            // 
            // difficulty_label
            // 
            this.difficulty_label.AutoSize = true;
            this.difficulty_label.Location = new System.Drawing.Point(12, 123);
            this.difficulty_label.Name = "difficulty_label";
            this.difficulty_label.Size = new System.Drawing.Size(47, 13);
            this.difficulty_label.TabIndex = 4;
            this.difficulty_label.Text = "Difficulty";
            // 
            // difficulty_comboBox
            // 
            this.difficulty_comboBox.FormattingEnabled = true;
            this.difficulty_comboBox.Location = new System.Drawing.Point(82, 123);
            this.difficulty_comboBox.Name = "difficulty_comboBox";
            this.difficulty_comboBox.Size = new System.Drawing.Size(121, 21);
            this.difficulty_comboBox.TabIndex = 5;
            // 
            // returnMain_btn
            // 
            this.returnMain_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnMain_btn.Location = new System.Drawing.Point(972, 378);
            this.returnMain_btn.Name = "returnMain_btn";
            this.returnMain_btn.Size = new System.Drawing.Size(115, 59);
            this.returnMain_btn.TabIndex = 6;
            this.returnMain_btn.Text = "Return";
            this.returnMain_btn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(224, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(564, 345);
            this.panel1.TabIndex = 7;
            // 
            // startGame_btn
            // 
            this.startGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startGame_btn.Location = new System.Drawing.Point(15, 315);
            this.startGame_btn.Name = "startGame_btn";
            this.startGame_btn.Size = new System.Drawing.Size(100, 58);
            this.startGame_btn.TabIndex = 8;
            this.startGame_btn.Text = "Start Game";
            this.startGame_btn.UseVisualStyleBackColor = true;
            // 
            // stopGame_btn
            // 
            this.stopGame_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stopGame_btn.Location = new System.Drawing.Point(15, 379);
            this.stopGame_btn.Name = "stopGame_btn";
            this.stopGame_btn.Size = new System.Drawing.Size(100, 58);
            this.stopGame_btn.TabIndex = 9;
            this.stopGame_btn.Text = "Stop Game";
            this.stopGame_btn.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(803, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(284, 344);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // gameSettings_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.stopGame_btn);
            this.Controls.Add(this.startGame_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.returnMain_btn);
            this.Controls.Add(this.difficulty_comboBox);
            this.Controls.Add(this.difficulty_label);
            this.Controls.Add(this.hidingTime_comboBox);
            this.Controls.Add(this.hideTime_label);
            this.Controls.Add(this.gameTime_label);
            this.Controls.Add(this.gameTime_comboBox);
            this.Name = "gameSettings_Page";
            this.Text = "Game settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox gameTime_comboBox;
        private System.Windows.Forms.Label gameTime_label;
        private System.Windows.Forms.Label hideTime_label;
        private System.Windows.Forms.ComboBox hidingTime_comboBox;
        private System.Windows.Forms.Label difficulty_label;
        private System.Windows.Forms.ComboBox difficulty_comboBox;
        private System.Windows.Forms.Button returnMain_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button startGame_btn;
        private System.Windows.Forms.Button stopGame_btn;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}
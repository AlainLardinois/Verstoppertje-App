namespace Verstoppertje_App.Forms
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.setupPanel = new System.Windows.Forms.Panel();
            this.startButton = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.gametimeLabel = new System.Windows.Forms.Label();
            this.difficultyBox = new System.Windows.Forms.ComboBox();
            this.timeBox = new System.Windows.Forms.ComboBox();
            this.setupLabel = new System.Windows.Forms.Label();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.endgameButton = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.loadingPanel = new System.Windows.Forms.Panel();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.loadingImage = new System.Windows.Forms.PictureBox();
            this.difficultyGroupBox = new System.Windows.Forms.GroupBox();
            this.timerGroupBox = new System.Windows.Forms.GroupBox();
            this.difficultyBoxLabel = new System.Windows.Forms.Label();
            this.upgradeBox = new System.Windows.Forms.GroupBox();
            this.upgradeComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationBalcony = new System.Windows.Forms.Button();
            this.locationBedroom1 = new System.Windows.Forms.Button();
            this.locationBedroom2 = new System.Windows.Forms.Button();
            this.locationBedroom3 = new System.Windows.Forms.Button();
            this.locationBathroom = new System.Windows.Forms.Button();
            this.locationGarderobe = new System.Windows.Forms.Button();
            this.locationStorage = new System.Windows.Forms.Button();
            this.locationScullery = new System.Windows.Forms.Button();
            this.locationToilet = new System.Windows.Forms.Button();
            this.locationCorridor1 = new System.Windows.Forms.Button();
            this.locationCorridor2 = new System.Windows.Forms.Button();
            this.locationLiving = new System.Windows.Forms.Button();
            this.locationKitchen = new System.Windows.Forms.Button();
            this.setupPanel.SuspendLayout();
            this.gamePanel.SuspendLayout();
            this.loadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImage)).BeginInit();
            this.difficultyGroupBox.SuspendLayout();
            this.timerGroupBox.SuspendLayout();
            this.upgradeBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // setupPanel
            // 
            this.setupPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setupPanel.Controls.Add(this.startButton);
            this.setupPanel.Controls.Add(this.difficultyLabel);
            this.setupPanel.Controls.Add(this.gametimeLabel);
            this.setupPanel.Controls.Add(this.difficultyBox);
            this.setupPanel.Controls.Add(this.timeBox);
            this.setupPanel.Controls.Add(this.setupLabel);
            this.setupPanel.Location = new System.Drawing.Point(12, 12);
            this.setupPanel.Name = "setupPanel";
            this.setupPanel.Size = new System.Drawing.Size(890, 482);
            this.setupPanel.TabIndex = 0;
            // 
            // startButton
            // 
            this.startButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.startButton.Location = new System.Drawing.Point(394, 277);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(112, 34);
            this.startButton.TabIndex = 13;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Location = new System.Drawing.Point(295, 213);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(89, 24);
            this.difficultyLabel.TabIndex = 12;
            this.difficultyLabel.Text = "Difficulty";
            // 
            // gametimeLabel
            // 
            this.gametimeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gametimeLabel.AutoSize = true;
            this.gametimeLabel.Location = new System.Drawing.Point(295, 162);
            this.gametimeLabel.Name = "gametimeLabel";
            this.gametimeLabel.Size = new System.Drawing.Size(105, 24);
            this.gametimeLabel.TabIndex = 11;
            this.gametimeLabel.Text = "Game time";
            // 
            // difficultyBox
            // 
            this.difficultyBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difficultyBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.difficultyBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.difficultyBox.FormattingEnabled = true;
            this.difficultyBox.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.difficultyBox.Location = new System.Drawing.Point(421, 210);
            this.difficultyBox.Name = "difficultyBox";
            this.difficultyBox.Size = new System.Drawing.Size(217, 32);
            this.difficultyBox.TabIndex = 10;
            // 
            // timeBox
            // 
            this.timeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.timeBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.timeBox.FormattingEnabled = true;
            this.timeBox.Items.AddRange(new object[] {
            "5 Minutes",
            "10 Minutes",
            "15 Minutes"});
            this.timeBox.Location = new System.Drawing.Point(421, 159);
            this.timeBox.Name = "timeBox";
            this.timeBox.Size = new System.Drawing.Size(217, 32);
            this.timeBox.TabIndex = 9;
            // 
            // setupLabel
            // 
            this.setupLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.setupLabel.AutoSize = true;
            this.setupLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setupLabel.Location = new System.Drawing.Point(396, 24);
            this.setupLabel.Name = "setupLabel";
            this.setupLabel.Size = new System.Drawing.Size(110, 41);
            this.setupLabel.TabIndex = 8;
            this.setupLabel.Text = "Setup";
            // 
            // gamePanel
            // 
            this.gamePanel.Controls.Add(this.panel1);
            this.gamePanel.Controls.Add(this.upgradeBox);
            this.gamePanel.Controls.Add(this.timerGroupBox);
            this.gamePanel.Controls.Add(this.difficultyGroupBox);
            this.gamePanel.Controls.Add(this.richTextBox1);
            this.gamePanel.Controls.Add(this.endgameButton);
            this.gamePanel.Location = new System.Drawing.Point(12, 12);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(890, 482);
            this.gamePanel.TabIndex = 14;
            this.gamePanel.Visible = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.richTextBox1.Location = new System.Drawing.Point(538, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(315, 245);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // endgameButton
            // 
            this.endgameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.endgameButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.endgameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.endgameButton.ForeColor = System.Drawing.Color.Red;
            this.endgameButton.Location = new System.Drawing.Point(745, 438);
            this.endgameButton.Name = "endgameButton";
            this.endgameButton.Size = new System.Drawing.Size(134, 34);
            this.endgameButton.TabIndex = 5;
            this.endgameButton.Text = "End game";
            this.endgameButton.UseVisualStyleBackColor = true;
            this.endgameButton.Click += new System.EventHandler(this.endgameButton_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.timerLabel.Location = new System.Drawing.Point(40, 19);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(54, 21);
            this.timerLabel.TabIndex = 0;
            this.timerLabel.Text = "00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 1000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // loadingPanel
            // 
            this.loadingPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingPanel.Controls.Add(this.loadingLabel);
            this.loadingPanel.Controls.Add(this.loadingImage);
            this.loadingPanel.Location = new System.Drawing.Point(12, 12);
            this.loadingPanel.Name = "loadingPanel";
            this.loadingPanel.Size = new System.Drawing.Size(890, 482);
            this.loadingPanel.TabIndex = 15;
            this.loadingPanel.Visible = false;
            // 
            // loadingLabel
            // 
            this.loadingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadingLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.loadingLabel.Location = new System.Drawing.Point(359, 345);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(184, 46);
            this.loadingLabel.TabIndex = 2;
            this.loadingLabel.Text = "Loading...";
            // 
            // loadingImage
            // 
            this.loadingImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingImage.Image = ((System.Drawing.Image)(resources.GetObject("loadingImage.Image")));
            this.loadingImage.Location = new System.Drawing.Point(254, 83);
            this.loadingImage.Name = "loadingImage";
            this.loadingImage.Size = new System.Drawing.Size(382, 244);
            this.loadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loadingImage.TabIndex = 1;
            this.loadingImage.TabStop = false;
            // 
            // difficultyGroupBox
            // 
            this.difficultyGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difficultyGroupBox.Controls.Add(this.difficultyBoxLabel);
            this.difficultyGroupBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficultyGroupBox.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyGroupBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.difficultyGroupBox.Location = new System.Drawing.Point(538, 14);
            this.difficultyGroupBox.Name = "difficultyGroupBox";
            this.difficultyGroupBox.Size = new System.Drawing.Size(165, 51);
            this.difficultyGroupBox.TabIndex = 7;
            this.difficultyGroupBox.TabStop = false;
            this.difficultyGroupBox.Text = "Difficulty";
            // 
            // timerGroupBox
            // 
            this.timerGroupBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timerGroupBox.Controls.Add(this.timerLabel);
            this.timerGroupBox.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerGroupBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.timerGroupBox.Location = new System.Drawing.Point(720, 14);
            this.timerGroupBox.Name = "timerGroupBox";
            this.timerGroupBox.Size = new System.Drawing.Size(133, 51);
            this.timerGroupBox.TabIndex = 8;
            this.timerGroupBox.TabStop = false;
            this.timerGroupBox.Text = "Timer";
            // 
            // difficultyBoxLabel
            // 
            this.difficultyBoxLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difficultyBoxLabel.AutoSize = true;
            this.difficultyBoxLabel.Font = new System.Drawing.Font("Montserrat SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difficultyBoxLabel.Location = new System.Drawing.Point(73, 18);
            this.difficultyBoxLabel.Name = "difficultyBoxLabel";
            this.difficultyBoxLabel.Size = new System.Drawing.Size(22, 21);
            this.difficultyBoxLabel.TabIndex = 1;
            this.difficultyBoxLabel.Text = "--";
            this.difficultyBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // upgradeBox
            // 
            this.upgradeBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upgradeBox.Controls.Add(this.upgradeComboBox);
            this.upgradeBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.upgradeBox.Font = new System.Drawing.Font("Montserrat", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgradeBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.upgradeBox.Location = new System.Drawing.Point(538, 346);
            this.upgradeBox.Name = "upgradeBox";
            this.upgradeBox.Size = new System.Drawing.Size(315, 64);
            this.upgradeBox.TabIndex = 9;
            this.upgradeBox.TabStop = false;
            this.upgradeBox.Text = "Upgrades";
            // 
            // upgradeComboBox
            // 
            this.upgradeComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.upgradeComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.upgradeComboBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.upgradeComboBox.FormattingEnabled = true;
            this.upgradeComboBox.Location = new System.Drawing.Point(37, 23);
            this.upgradeComboBox.Name = "upgradeComboBox";
            this.upgradeComboBox.Size = new System.Drawing.Size(246, 26);
            this.upgradeComboBox.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.locationKitchen);
            this.panel1.Controls.Add(this.locationLiving);
            this.panel1.Controls.Add(this.locationCorridor2);
            this.panel1.Controls.Add(this.locationCorridor1);
            this.panel1.Controls.Add(this.locationToilet);
            this.panel1.Controls.Add(this.locationScullery);
            this.panel1.Controls.Add(this.locationStorage);
            this.panel1.Controls.Add(this.locationGarderobe);
            this.panel1.Controls.Add(this.locationBathroom);
            this.panel1.Controls.Add(this.locationBedroom3);
            this.panel1.Controls.Add(this.locationBedroom2);
            this.panel1.Controls.Add(this.locationBedroom1);
            this.panel1.Controls.Add(this.locationBalcony);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 482);
            this.panel1.TabIndex = 10;
            // 
            // locationBalcony
            // 
            this.locationBalcony.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationBalcony.BackColor = System.Drawing.Color.Transparent;
            this.locationBalcony.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBalcony.FlatAppearance.BorderSize = 0;
            this.locationBalcony.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationBalcony.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationBalcony.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBalcony.ForeColor = System.Drawing.Color.Transparent;
            this.locationBalcony.Location = new System.Drawing.Point(47, 21);
            this.locationBalcony.Name = "locationBalcony";
            this.locationBalcony.Size = new System.Drawing.Size(239, 108);
            this.locationBalcony.TabIndex = 0;
            this.locationBalcony.UseVisualStyleBackColor = false;
            this.locationBalcony.Click += new System.EventHandler(this.locationBalcony_Click);
            // 
            // locationBedroom1
            // 
            this.locationBedroom1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationBedroom1.BackColor = System.Drawing.Color.Transparent;
            this.locationBedroom1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBedroom1.FlatAppearance.BorderSize = 0;
            this.locationBedroom1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationBedroom1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationBedroom1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBedroom1.ForeColor = System.Drawing.Color.Transparent;
            this.locationBedroom1.Location = new System.Drawing.Point(321, 317);
            this.locationBedroom1.Name = "locationBedroom1";
            this.locationBedroom1.Size = new System.Drawing.Size(185, 108);
            this.locationBedroom1.TabIndex = 1;
            this.locationBedroom1.UseVisualStyleBackColor = false;
            this.locationBedroom1.Click += new System.EventHandler(this.locationBedroom1_Click);
            // 
            // locationBedroom2
            // 
            this.locationBedroom2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationBedroom2.BackColor = System.Drawing.Color.Transparent;
            this.locationBedroom2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBedroom2.FlatAppearance.BorderSize = 0;
            this.locationBedroom2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationBedroom2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationBedroom2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBedroom2.ForeColor = System.Drawing.Color.Transparent;
            this.locationBedroom2.Location = new System.Drawing.Point(321, 129);
            this.locationBedroom2.Name = "locationBedroom2";
            this.locationBedroom2.Size = new System.Drawing.Size(79, 142);
            this.locationBedroom2.TabIndex = 2;
            this.locationBedroom2.UseVisualStyleBackColor = false;
            this.locationBedroom2.Click += new System.EventHandler(this.locationBedroom2_Click);
            // 
            // locationBedroom3
            // 
            this.locationBedroom3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationBedroom3.BackColor = System.Drawing.Color.Transparent;
            this.locationBedroom3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBedroom3.FlatAppearance.BorderSize = 0;
            this.locationBedroom3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationBedroom3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationBedroom3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBedroom3.ForeColor = System.Drawing.Color.Transparent;
            this.locationBedroom3.Location = new System.Drawing.Point(403, 129);
            this.locationBedroom3.Name = "locationBedroom3";
            this.locationBedroom3.Size = new System.Drawing.Size(103, 142);
            this.locationBedroom3.TabIndex = 3;
            this.locationBedroom3.UseVisualStyleBackColor = false;
            this.locationBedroom3.Click += new System.EventHandler(this.locationBedroom3_Click);
            // 
            // locationBathroom
            // 
            this.locationBathroom.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationBathroom.BackColor = System.Drawing.Color.Transparent;
            this.locationBathroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationBathroom.FlatAppearance.BorderSize = 0;
            this.locationBathroom.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationBathroom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationBathroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationBathroom.ForeColor = System.Drawing.Color.Transparent;
            this.locationBathroom.Location = new System.Drawing.Point(183, 317);
            this.locationBathroom.Name = "locationBathroom";
            this.locationBathroom.Size = new System.Drawing.Size(139, 108);
            this.locationBathroom.TabIndex = 16;
            this.locationBathroom.UseVisualStyleBackColor = false;
            this.locationBathroom.Click += new System.EventHandler(this.locationBathroom_Click);
            // 
            // locationGarderobe
            // 
            this.locationGarderobe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationGarderobe.BackColor = System.Drawing.Color.Transparent;
            this.locationGarderobe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationGarderobe.FlatAppearance.BorderSize = 0;
            this.locationGarderobe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationGarderobe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationGarderobe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationGarderobe.ForeColor = System.Drawing.Color.Transparent;
            this.locationGarderobe.Location = new System.Drawing.Point(183, 317);
            this.locationGarderobe.Name = "locationGarderobe";
            this.locationGarderobe.Size = new System.Drawing.Size(29, 52);
            this.locationGarderobe.TabIndex = 17;
            this.locationGarderobe.UseVisualStyleBackColor = false;
            this.locationGarderobe.Click += new System.EventHandler(this.locationGarderobe_Click);
            // 
            // locationStorage
            // 
            this.locationStorage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationStorage.BackColor = System.Drawing.Color.Transparent;
            this.locationStorage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationStorage.FlatAppearance.BorderSize = 0;
            this.locationStorage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationStorage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationStorage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationStorage.ForeColor = System.Drawing.Color.Transparent;
            this.locationStorage.Location = new System.Drawing.Point(442, 268);
            this.locationStorage.Name = "locationStorage";
            this.locationStorage.Size = new System.Drawing.Size(64, 43);
            this.locationStorage.TabIndex = 18;
            this.locationStorage.UseVisualStyleBackColor = false;
            this.locationStorage.Click += new System.EventHandler(this.locationStorage_Click);
            // 
            // locationScullery
            // 
            this.locationScullery.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationScullery.BackColor = System.Drawing.Color.Transparent;
            this.locationScullery.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationScullery.FlatAppearance.BorderSize = 0;
            this.locationScullery.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationScullery.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationScullery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationScullery.ForeColor = System.Drawing.Color.Transparent;
            this.locationScullery.Location = new System.Drawing.Point(13, 300);
            this.locationScullery.Name = "locationScullery";
            this.locationScullery.Size = new System.Drawing.Size(106, 125);
            this.locationScullery.TabIndex = 19;
            this.locationScullery.UseVisualStyleBackColor = false;
            this.locationScullery.Click += new System.EventHandler(this.locationScullery_Click);
            // 
            // locationToilet
            // 
            this.locationToilet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationToilet.BackColor = System.Drawing.Color.Transparent;
            this.locationToilet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationToilet.FlatAppearance.BorderSize = 0;
            this.locationToilet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationToilet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationToilet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationToilet.ForeColor = System.Drawing.Color.Transparent;
            this.locationToilet.Location = new System.Drawing.Point(66, 361);
            this.locationToilet.Name = "locationToilet";
            this.locationToilet.Size = new System.Drawing.Size(53, 64);
            this.locationToilet.TabIndex = 20;
            this.locationToilet.UseVisualStyleBackColor = false;
            this.locationToilet.Click += new System.EventHandler(this.locationToilet_Click);
            // 
            // locationCorridor1
            // 
            this.locationCorridor1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationCorridor1.BackColor = System.Drawing.Color.Transparent;
            this.locationCorridor1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationCorridor1.FlatAppearance.BorderSize = 0;
            this.locationCorridor1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationCorridor1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationCorridor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationCorridor1.ForeColor = System.Drawing.Color.Transparent;
            this.locationCorridor1.Location = new System.Drawing.Point(183, 268);
            this.locationCorridor1.Name = "locationCorridor1";
            this.locationCorridor1.Size = new System.Drawing.Size(263, 44);
            this.locationCorridor1.TabIndex = 21;
            this.locationCorridor1.UseVisualStyleBackColor = false;
            this.locationCorridor1.Click += new System.EventHandler(this.locationCorridor1_Click);
            // 
            // locationCorridor2
            // 
            this.locationCorridor2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationCorridor2.BackColor = System.Drawing.Color.Transparent;
            this.locationCorridor2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationCorridor2.FlatAppearance.BorderSize = 0;
            this.locationCorridor2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationCorridor2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationCorridor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationCorridor2.ForeColor = System.Drawing.Color.Transparent;
            this.locationCorridor2.Location = new System.Drawing.Point(122, 268);
            this.locationCorridor2.Name = "locationCorridor2";
            this.locationCorridor2.Size = new System.Drawing.Size(55, 151);
            this.locationCorridor2.TabIndex = 22;
            this.locationCorridor2.UseVisualStyleBackColor = false;
            this.locationCorridor2.Click += new System.EventHandler(this.locationCorridor2_Click);
            // 
            // locationLiving
            // 
            this.locationLiving.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLiving.BackColor = System.Drawing.Color.Transparent;
            this.locationLiving.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationLiving.FlatAppearance.BorderSize = 0;
            this.locationLiving.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationLiving.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationLiving.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationLiving.ForeColor = System.Drawing.Color.Transparent;
            this.locationLiving.Location = new System.Drawing.Point(13, 129);
            this.locationLiving.Name = "locationLiving";
            this.locationLiving.Size = new System.Drawing.Size(309, 142);
            this.locationLiving.TabIndex = 23;
            this.locationLiving.UseVisualStyleBackColor = false;
            this.locationLiving.Click += new System.EventHandler(this.locationLiving_Click);
            // 
            // locationKitchen
            // 
            this.locationKitchen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationKitchen.BackColor = System.Drawing.Color.Transparent;
            this.locationKitchen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.locationKitchen.FlatAppearance.BorderSize = 0;
            this.locationKitchen.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Indigo;
            this.locationKitchen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Indigo;
            this.locationKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.locationKitchen.ForeColor = System.Drawing.Color.Transparent;
            this.locationKitchen.Location = new System.Drawing.Point(13, 196);
            this.locationKitchen.Name = "locationKitchen";
            this.locationKitchen.Size = new System.Drawing.Size(106, 105);
            this.locationKitchen.TabIndex = 24;
            this.locationKitchen.UseVisualStyleBackColor = false;
            this.locationKitchen.Click += new System.EventHandler(this.locationKitchen_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(914, 506);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.setupPanel);
            this.Controls.Add(this.loadingPanel);
            this.Font = new System.Drawing.Font("Montserrat", 10.2F);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GameForm";
            this.Text = "GameForm";
            this.setupPanel.ResumeLayout(false);
            this.setupPanel.PerformLayout();
            this.gamePanel.ResumeLayout(false);
            this.loadingPanel.ResumeLayout(false);
            this.loadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingImage)).EndInit();
            this.difficultyGroupBox.ResumeLayout(false);
            this.difficultyGroupBox.PerformLayout();
            this.timerGroupBox.ResumeLayout(false);
            this.timerGroupBox.PerformLayout();
            this.upgradeBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel setupPanel;
        private System.Windows.Forms.ComboBox timeBox;
        private System.Windows.Forms.Label setupLabel;
        private System.Windows.Forms.ComboBox difficultyBox;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.Label gametimeLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button endgameButton;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Panel loadingPanel;
        private System.Windows.Forms.PictureBox loadingImage;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.GroupBox timerGroupBox;
        private System.Windows.Forms.GroupBox difficultyGroupBox;
        private System.Windows.Forms.Label difficultyBoxLabel;
        private System.Windows.Forms.GroupBox upgradeBox;
        private System.Windows.Forms.ComboBox upgradeComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button locationBalcony;
        private System.Windows.Forms.Button locationLiving;
        private System.Windows.Forms.Button locationCorridor2;
        private System.Windows.Forms.Button locationCorridor1;
        private System.Windows.Forms.Button locationToilet;
        private System.Windows.Forms.Button locationScullery;
        private System.Windows.Forms.Button locationStorage;
        private System.Windows.Forms.Button locationGarderobe;
        private System.Windows.Forms.Button locationBathroom;
        private System.Windows.Forms.Button locationBedroom3;
        private System.Windows.Forms.Button locationBedroom2;
        private System.Windows.Forms.Button locationBedroom1;
        private System.Windows.Forms.Button locationKitchen;
    }
}
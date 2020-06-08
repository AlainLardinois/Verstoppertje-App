using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verstoppertje_App.Forms
{
    public partial class GameForm : Form
    {
        private int minutes = 0;
        private int seconds = 0;
        public GameForm()
        {
            Console.WriteLine("Loading...");
            InitializeComponent();
            Program.form.SetGameInProgress(true);
            timeBox.SelectedIndex = 0;
            difficultyBox.SelectedIndex = 0;
            timerLabel.Text = minutes.ToString("D2") + ':' + seconds.ToString("D2");
            Console.WriteLine("Loaded...");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            difficultyBoxLabel.Text = difficultyBox.SelectedItem.ToString();
            if (timeBox.SelectedIndex == 0)
            {
                minutes = 1;
            }
            else if (timeBox.SelectedIndex == 1)
            {
                minutes = 10;
            }
            else if (timeBox.SelectedIndex == 2)
            {
                minutes = 15;
            }
            loadingPanel.Visible = true;
            setupPanel.Visible = false;
            Task.Delay(2000);
            gamePanel.Visible = true;
            loadingPanel.Visible = false;
            gameTimer.Start();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (minutes > 0)
            {
                if (seconds == 0)
                {
                    minutes--;
                    seconds = 60;
                }
                seconds--;
                timerLabel.Text = minutes.ToString("D2") + ':' + seconds.ToString("D2");
            }
            else if (minutes == 0 && seconds == 0)
            {
                gameTimer.Stop();
                EndGame();
            }
            else
            {
                seconds--;
                timerLabel.Text = minutes.ToString("D2") + ':' + seconds.ToString("D2");
            }
        }

        private void EndGame()
        {
            MessageBox.Show("Game has ended!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            locationBalcony.Enabled = false;
            locationBathroom.Enabled = false;
            locationBedroom1.Enabled = false;
            locationBedroom2.Enabled = false;
            locationBedroom3.Enabled = false;
            locationToilet.Enabled = false;
            locationStorage.Enabled = false;
            locationCorridor1.Enabled = false;
            locationCorridor2.Enabled = false;
            locationKitchen.Enabled = false;
            locationGarderobe.Enabled = false;
            locationLiving.Enabled = false;
            locationScullery.Enabled = false;
            endgameButton.Enabled = false;
            upgradeComboBox.Enabled = false;
            Program.form.SetGameInProgress(false);
        }

        private void endgameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the game? Your progress will be lost.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                gameTimer.Stop();
                Program.form.SetGameInProgress(false);
                Program.form.ResetView();
            }
        }

        private void locationBalcony_Click(object sender, EventArgs e)
        {

        }

        private void locationKitchen_Click(object sender, EventArgs e)
        {

        }

        private void locationLiving_Click(object sender, EventArgs e)
        {

        }

        private void locationBedroom2_Click(object sender, EventArgs e)
        {

        }

        private void locationBedroom3_Click(object sender, EventArgs e)
        {

        }

        private void locationStorage_Click(object sender, EventArgs e)
        {

        }

        private void locationBedroom1_Click(object sender, EventArgs e)
        {

        }

        private void locationCorridor1_Click(object sender, EventArgs e)
        {

        }

        private void locationBathroom_Click(object sender, EventArgs e)
        {

        }

        private void locationGarderobe_Click(object sender, EventArgs e)
        {

        }

        private void locationCorridor2_Click(object sender, EventArgs e)
        {

        }

        private void locationScullery_Click(object sender, EventArgs e)
        {

        }

        private void locationToilet_Click(object sender, EventArgs e)
        {

        }
    }
}

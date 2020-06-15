using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verstoppertje_App.DataAccessLayer;
using Verstoppertje_App.Model;
using Verstoppertje_App.Domoticz;

namespace Verstoppertje_App.Forms
{
    public partial class GameForm : Form
    {
        private int minutes = 0;
        private int seconds = 0;
        private string currentHidingLocation;
        private bool found;
        private int clicks;
        private int maxClicks;
        private DateTime start;
        private DateTime end;
        private double score;
        private DAL dal = new DAL();
        private DomoticzAPI api;
        private Thread getLogThread;
        private List<string> currentLogs = new List<string>();
        public GameForm()
        {
            InitializeComponent();
            timeBox.SelectedIndex = 0;
            difficultyBox.SelectedIndex = 0;
            timerLabel.Text = minutes.ToString("D2") + ':' + seconds.ToString("D2");
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            Program.form.SetGameInProgress(true);
            difficultyBoxLabel.Text = difficultyBox.SelectedItem.ToString();
            int scene = 1;
            if (timeBox.SelectedIndex == 0)
            {
                minutes = 5;
            }
            else if (timeBox.SelectedIndex == 1)
            {
                minutes = 10;
            }
            else if (timeBox.SelectedIndex == 2)
            {
                minutes = 15;
            }
            if (difficultyBox.SelectedIndex == 0)
            {
                currentHidingLocation = "Bedroom1";
                scene = 1;
                maxClicks = 4;
                score = 100;
            }
            else if (difficultyBox.SelectedIndex == 1)
            {
                currentHidingLocation = "Bathroom";
                scene = 2;
                maxClicks = 3;
                score = 200;
            }
            else if (difficultyBox.SelectedIndex == 2)
            {
                currentHidingLocation = "Storage";
                scene = 3;
                maxClicks = 2;
                score = 300;
            }
            clicksLabel.Text = (maxClicks - clicks).ToString();
            gamePanel.Visible = true;
            setupPanel.Visible = false;
            start = DateTime.Now;
            gameTimer.Start();
            api = new DomoticzAPI(start);
            getLogThread = new Thread(api.GetLogs);
            getLogThread.Start();
            api.ToggleScene(scene);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            score -= 0.3;
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

            // Show logs
            foreach (string msg in api.logs)
            {
                if (!currentLogs.Contains(msg))
                {
                    currentLogs.Add(msg);
                    logTextBox.AppendText(msg + "\n");
                }
            }
        }

        private void EndGame()
        {
            gameTimer.Stop();
            end = DateTime.Now;
            getLogThread.Abort();
            TimeSpan duration = end.Subtract(start);
            timeLabel.Text = duration.Minutes.ToString("D2") + ':' + duration.Seconds.ToString("D2");
            int finalScore = 0;
            if (found)
            {
                wonLabel.Text = "won";
                wonLabel.ForeColor = System.Drawing.Color.LimeGreen;
                finalScore = Convert.ToInt32(score);
            }
            else
            {
                wonLabel.Text = "lost";
                wonLabel.ForeColor = System.Drawing.Color.Red;
            }
            scoreLabel.Text = finalScore.ToString() + " credits";
            statsPanel.Visible = true;
            gamePanel.Visible = false;
            Program.form.SetGameInProgress(false);
            dal.GetData();
            GameRole role = dal.roles.Find(i => i.Id == 2);
            dal.SaveScore(found, role, finalScore, Program.form.GetUser());
        }

        private void endgameButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to end the game? Your progress will be lost.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                gameTimer.Stop();
                getLogThread.Abort();
                Program.form.SetGameInProgress(false);
                Program.form.ResetView();
            }
        }

        private void locationBalcony_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Balcony")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationKitchen_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Kitchen")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationLiving_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Living")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationBedroom2_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Bedroom2")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationBedroom3_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Bedroom3")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationStorage_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Storage")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationBedroom1_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Bedroom1")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationCorridor1_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Corridor1")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationBathroom_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Bathroom")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationGarderobe_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Garderobe")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationCorridor2_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Corridor2")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationScullery_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Scullery")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }

        private void locationToilet_Click(object sender, EventArgs e)
        {
            if (clicks < maxClicks)
            {
                clicks += 1;
                clicksLabel.Text = (maxClicks - clicks).ToString();
                if (currentHidingLocation == "Toilet")
                {
                    found = true;
                    EndGame();
                }
                if (clicks == maxClicks)
                {
                    EndGame();
                }
            }
            else
            {
                EndGame();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Verstoppertje_App.DataAccessLayer;
using Verstoppertje_App.Model;
using Verstoppertje_App.Domoticz;

namespace Verstoppertje_App.Forms
{
    public partial class MainLayout : Form
    {
        private Form activeContentForm = null;
        private int activeUser = 0;
        private DAL dal = new DAL();
        private bool gameInProgress = false;
        public MainLayout()
        {
            InitializeComponent();
            ChangeContentForm(new LoginForm());
        }

        public void SetUser(User user)
        {
            activeUser = user.Id;
        }

        public User GetUser()
        {
            dal.GetData();
            User user = dal.users.Find(i => i.Id == activeUser);
            return user;
        }

        public void UpdateUser()
        {
            if (activeUser != 0)
            {
                User user = GetUser();
                profileButton.Text = user.First_name + ' ' + user.Last_name;
                profileButton.Show();
                logoutMenuButton.Text = "Logout";
            }
            else
            {
                profileButton.Hide();
                logoutMenuButton.Text = "Exit";
            }
        }

        private void ChangeContentForm(Form contentForm)
        {
            if (activeContentForm != null)
            {
                activeContentForm.Close();
            }
            activeContentForm = contentForm;
            contentForm.TopLevel = false;
            contentForm.FormBorderStyle = FormBorderStyle.None;
            contentForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(contentForm);
            contentPanel.Tag = contentForm;
            contentForm.BringToFront();
            contentForm.Show();
            UpdateUser();
        } 

        private void homeMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != 0)
            {
                if (gameInProgress != true)
                {
                    ResetView();
                }
                else
                {
                    MessageBox.Show("You cannot visit another tab while in a game!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void gameMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != 0)
            {
                if (gameInProgress != true)
                {
                    ChangeContentForm(new GameForm());
                }
            }
        }

        private void leaderBoardMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != 0)
            {
                if (gameInProgress != true)
                {
                    ChangeContentForm(new LeaderBoardForm());
                }
                else
                {
                    MessageBox.Show("You cannot visit another tab while in a game!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void shopMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != 0)
            {
                if (gameInProgress != true)
                {
                    ChangeContentForm(new ShopForm());
                }
                else
                {
                    MessageBox.Show("You cannot visit another tab while in a game!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            if (activeUser != 0)
            {
                if (gameInProgress != true)
                {
                    ChangeContentForm(new ProfileForm());
                }
                else
                {
                    MessageBox.Show("You cannot visit another tab while in a game!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void logoutMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != 0)
            {
                if (gameInProgress != true)
                {
                    activeUser = 0;
                    ChangeContentForm(new LoginForm());
                }
                else
                {
                    MessageBox.Show("You cannot logout while in a game!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                Close();
            }
        }

        private void helpMenuButton_Click(object sender, EventArgs e)
        {
            if (gameInProgress != true)
            {
                ChangeContentForm(new HelpForm());
            }
            else
            {
                MessageBox.Show("You cannot visit another tab while in a game!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void ResetView()
        {
            if (activeContentForm != null)
            {
                activeContentForm.Close();
                activeContentForm = null;
            }
            UpdateUser();
        }

        public void SetGameInProgress(bool inProgress)
        {
            gameInProgress = inProgress;
        }
    }
}

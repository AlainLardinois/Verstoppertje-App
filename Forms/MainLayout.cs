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

namespace Verstoppertje_App.Forms
{
    public partial class MainLayout : Form
    {
        private Form activeContentForm = null;
        private User activeUser = null;
        public MainLayout()
        {
            InitializeComponent();
            ChangeContentForm(new LoginForm());
        }

        private void UpdateUser()
        {
            if (activeUser != null)
            {
                profileButton.Text = activeUser.First_name + ' ' + activeUser.Last_name;
                profileButton.Show();
                logoutMenuButton.Show();
            }
            else
            {
                profileButton.Hide();
                logoutMenuButton.Hide();
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
            if (activeUser != null)
            {
                // ...
            }
        }

        private void gameMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != null)
            {
                // ...
            }
        }

        private void leaderBoardMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != null)
            {
                // ...
            }
        }

        private void shopMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != null)
            {
                ChangeContentForm(new ShopForm());
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            if (activeUser != null)
            {
                // ...
            }
        }

        private void logoutMenuButton_Click(object sender, EventArgs e)
        {
            activeUser = null;
            ChangeContentForm(new LoginForm());
        }

        private void helpMenuButton_Click(object sender, EventArgs e)
        {
            if (activeUser != null)
            {
                // ...
            }
        }

        public void SetUser(User user)
        {
            activeUser = user;
        }

        public User GetUser()
        {
            return activeUser;
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
    }
}

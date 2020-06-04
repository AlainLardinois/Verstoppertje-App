using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verstoppertje_App
{
    public partial class userMain_Page : Form
    {
        public userMain_Page()
        {
            InitializeComponent();
        }

        private void playGame_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameSettings_Page GameMenu = new gameSettings_Page();
            GameMenu.Closed += (s, args) => this.Close();
            GameMenu.Show();
        }

        private void itemShop_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userShop_Page ItemShop = new userShop_Page();
            ItemShop.Closed += (s, args) => this.Close();
            ItemShop.Show();
        }

        private void myProfile_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userProfile_Page MyProfile = new userProfile_Page();
            MyProfile.Closed += (s, args) => this.Close();
            MyProfile.Show();
        }

        private void exitGame_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

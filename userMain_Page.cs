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
            gameSettings_Page GameMenu = new gameSettings_Page();
            GameMenu.Show();
            userMain_Page.ActiveForm.Close();
        }

        private void itemShop_btn_Click(object sender, EventArgs e)
        {
            userShop_Page ItemShop = new userShop_Page();
            ItemShop.Show();
            userMain_Page.ActiveForm.Close();
        }

        private void myProfile_btn_Click(object sender, EventArgs e)
        {
            userProfile_Page MyProfile = new userProfile_Page();
            MyProfile.Show();
            userMain_Page.ActiveForm.Close();
        }

        private void exitGame_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

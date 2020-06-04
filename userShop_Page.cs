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
    public partial class userShop_Page : Form
    {
        public userShop_Page()
        {
            InitializeComponent();
        }

        private void powerUp4_picBox_Click(object sender, EventArgs e)
        {

        }

        private void returnMain_btn_Click(object sender, EventArgs e)
        {
            userMain_Page MainMenu = new userMain_Page();
            MainMenu.Show();
            userShop_Page.ActiveForm.Close();
        }
    }
}

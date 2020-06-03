using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Verstoppertje-App.DataAccessLayer;
//using Verstoppertje_App.Model;

namespace Verstoppertje_App
{
    public partial class signUp_Page : Form
    {
        public signUp_Page()
        {
            InitializeComponent();
        }

        private void signUp_btn_Click(object sender, EventArgs e)
        {
            string GameName = this.userGameName_tBox.Text;
            string Username = this.userName_tBox.Text;
            string Password = this.userPassword_tBox.Text;
            string Email = this.userEmail_tBox.Text;


            if ((GameName ?? Username ?? Password ?? Email) != null)
            {
                string nickname = DAL.users.Find(i => i.nickname == newNickName);
            }
            else
            {
                MessageBox.Show("Waarschuwing", "u heeft niet alle gegevens ingevuld", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void exitMenu_btn_Click(object sender, EventArgs e)
        {
            signUp_Page.ActiveForm.Close();
        }
    }
}

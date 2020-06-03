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

namespace Verstoppertje_App
{
    public partial class signUp_Page : Form
    {
        public signUp_Page()
        {
            InitializeComponent();
            
        }

        DAL myDAL = new DAL(); //Referentie naar Data Access Layer


        private void signUp_btn_Click(object sender, EventArgs e)
        {
            string GameName = this.userGameName_tBox.Text;
            string FirstName = this.userFirstName_tBox.Text;
            string LastName = this.userLastName_tBox.Text;
            string Password = this.userPassword_tBox.Text;
            string Email = this.userEmail_tBox.Text;


            if ((GameName ?? FirstName ?? LastName ?? Password ?? Email) != null)
            {
                User user = myDAL.users.Find(i => i.Nickname == GameName);
                if (user == null)
                {
                    MessageBox.Show("Waarschuwing", "Gebruik bestaad al", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    myDAL.GetData();
                    UserType type = myDAL.types.Find(i => i.Id == 1);
                    myDAL.SaveUser(GameName, FirstName, LastName, type, Password, Email);
                    signUp_Page.ActiveForm.Close();
                }

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

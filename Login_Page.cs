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
    public partial class login_Page : Form
    {
        public login_Page()
        {
            InitializeComponent();

        }

        DAL myDAL = new DAL(); //Referentie naar Data Access Layer

        private void UserLogin_btn_Click(object sender, EventArgs e) //Open Main_page als Username + Wachtwoord Klopt. zo niet Error.
        {
            string GameName = this.userGameName_tBox.Text;
            string Password = this.userPassword_tBox.Text;

            try
            {
                myDAL.GetData();
                User user = myDAL.users.Find(i => i.Nickname == GameName);
                user.VerifyPassword(Password); // Might throw an error
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Password is incorrect please try again", "Waning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Game Name Doesn't exist try again ", "Waning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserSignUp_btn_Click(object sender, EventArgs e) //Open SignUp_Page, Registreer als nieuwe gebruiker
        {
            signUp_Page signUp = new signUp_Page();
            signUp.Show();
        }

        private void ForgotMyPass_btn_Click(object sender, EventArgs e) //verwijzing naar pagina waar je wachtwoord kunt resetten
        {
            
        }

        private void exitGame_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

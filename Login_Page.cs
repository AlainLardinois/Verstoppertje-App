using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Verstoppertje_App.DataAccessLayer;
//using Verstoppertje_App.Model;


namespace Verstoppertje_App
{
    public partial class login_Page : Form
    {
        public login_Page()
        {
            InitializeComponent();

            

        }

        private void UserLogin_btn_Click(object sender, EventArgs e) //Open Main_page als Username + Wachtwoord Klopt. zo niet Error.
        {
            string Username = this.userName_tBox.Text;
            string Password = this.userPassword_tBox.Text;
            if (Username == Sql + Password == sql) //Referenctie naar DAL voor Wachtwoord ophalen uit DB)
            {
                userMain_Page MainMenu = new userMain_Page();
                MainMenu.Show();
                login_Page.ActiveForm.Close();
            }
            else
            {
                MessageBox.Show("Waning", "Username or Password is incorrect please try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}

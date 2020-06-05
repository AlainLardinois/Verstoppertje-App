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
            List<String> textBoxes = new List<string>();
            textBoxes.Add(this.userGameName_tBox.Text);
            textBoxes.Add(this.userPassword_tBox.Text);

            if (!textBoxes.Any(s => String.IsNullOrEmpty(s)))
            {
                try
                {
                    myDAL.GetData();
                    User user = myDAL.users.Find(i => i.Nickname == textBoxes[0]);
                    user.VerifyPassword(textBoxes[1]);
                    MessageBox.Show("Your password is correct!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    userMain_Page MainMenu = new userMain_Page();
                    MainMenu.Closed += (s, args) => this.Close();
                    MainMenu.Show();
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Your password is incorrect, please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("That username doesn't exist, please try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You have to fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UserSignUp_btn_Click(object sender, EventArgs e) //Open SignUp_Page, Registreer als nieuwe gebruiker
        {
            this.signupPanel.Visible = true;
        }

        private void ForgotMyPass_btn_Click(object sender, EventArgs e) //verwijzing naar pagina waar je wachtwoord kunt resetten
        {
            
        }

        private void exitGame_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.signupPanel.Visible = false;
        }
    }
}

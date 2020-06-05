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
    public partial class LoginForm : Form
    {
        private DAL dal = new DAL();
        public LoginForm()
        {
            InitializeComponent();
            dal.GetData();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(userNameText);
            textBoxes.Add(passwordText);

            if (!textBoxes.Any(s => String.IsNullOrEmpty(s)))
            {
                try
                {
                    User user = dal.users.Find(i => i.Nickname == textBoxes[0].Text);
                    user.VerifyPassword(textBoxes[1].Text);
                    Program.form.SetUser(user);
                    Program.form.ResetView(); // Change for home form later
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Your password is incorrect. Please try again.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("An account with that username doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void forgotPasswordButton_Click(object sender, EventArgs e)
        {
            passResetPanel.Visible = true;
        }

        private void signupButton_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = true;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            passResetPanel.Visible = false;
        }

        private void passResetButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have received an e-mail with instructions how to reset your password.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            passResetPanel.Visible = false;
            emailResetText.Clear();
        }

        private void sBackButton_Click(object sender, EventArgs e)
        {
            signupPanel.Visible = false;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            List<TextBox> textBoxes = new List<TextBox>();
            textBoxes.Add(newUsernameText);
            textBoxes.Add(newFirstnameText);
            textBoxes.Add(newLastnameText);
            textBoxes.Add(newEmailText);
            textBoxes.Add(newPasswordText);

            if (!textBoxes.Any(s => String.IsNullOrEmpty(s)))
            {
                User user = dal.users.Find(i => i.Nickname == textBoxes[0].Text);
                if (user != null)
                {
                    MessageBox.Show("This username is already taken!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    User emailUser = dal.users.Find(i => i.Nickname == textBoxes[3].Text);
                    if (emailUser != null)
                    {
                        MessageBox.Show("This e-mailadress is already in use!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        UserType type = dal.types.Find(i => i.Id == 1);
                        dal.SaveUser(textBoxes[0].Text, textBoxes[1].Text, textBoxes[2].Text, type, textBoxes[4].Text, textBoxes[3].Text);
                        MessageBox.Show("Your account is created!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        signupPanel.Visible = false;
                        textBoxes.ForEach(i => i.Clear());
                    }
                }
            }
        }
    }
}

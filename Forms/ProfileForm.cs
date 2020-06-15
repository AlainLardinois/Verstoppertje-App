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
    public partial class ProfileForm : Form
    {
        private DAL dal = new DAL();
        public ProfileForm()
        {
            InitializeComponent();
            UpdateFields();
        }

        private void UpdateFields()
        {
            User user = Program.form.GetUser();
            usernameText.Text = user.Nickname;
            firstnameText.Text = user.First_name;
            lastnameText.Text = user.Last_name;
            emailText.Text = user.Email;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            User editUser = Program.form.GetUser();
            editUser.Nickname = usernameText.Text;
            editUser.First_name = firstnameText.Text;
            editUser.Last_name = lastnameText.Text;
            editUser.Email = emailText.Text;
            dal.UpdateUser(editUser, passwordText.Text);
            MessageBox.Show("Your user details have been updated!", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateFields();
            Program.form.UpdateUser();
        }
    }
}

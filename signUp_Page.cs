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
            List<String> textBoxes = new List<string>();
            textBoxes.Add(this.userGameName_tBox.Text);
            textBoxes.Add(this.userFirstName_tBox.Text);
            textBoxes.Add(this.userLastName_tBox.Text);
            textBoxes.Add(this.userPassword_tBox.Text);
            textBoxes.Add(this.userEmail_tBox.Text);

            if (!textBoxes.Any(s => String.IsNullOrEmpty(s)))
            {
                User user = myDAL.users.Find(i => i.Nickname == textBoxes[0]);
                Console.WriteLine(user);
                if (user != null)
                {
                    MessageBox.Show("User already exists", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    myDAL.GetData();
                    UserType type = myDAL.types.Find(i => i.Id == 1);
                    myDAL.SaveUser(textBoxes[0], textBoxes[1], textBoxes[2], type, textBoxes[3], textBoxes[4]);
                    signUp_Page.ActiveForm.Close();
                }
                else
                {
                    MessageBox.Show("User already exist", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("You have to fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }      
        }

        private void exitMenu_btn_Click(object sender, EventArgs e)
        {
            signUp_Page.ActiveForm.Close();
        }
    }
}

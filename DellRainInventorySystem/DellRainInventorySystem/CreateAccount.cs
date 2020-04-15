using System;
using System.Linq;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;

namespace DellRainInventorySystem
{
    public partial class CreateAccount : Form
    {
        private Inventory inventory = new Inventory();
        private int _classifier = 0;

        public CreateAccount()
        {
            InitializeComponent();
        }

        private void pictureBack_Click(object sender, EventArgs e) => this.Close();

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            if (!CheckEmptyFields()) 
            {
              
                InventoryUtils.LtuUsers.AddLast(new User(tbFirstName.Text, tbLastName.Text, cbGender.SelectedItem.ToString(), tbUsername.Text,
                    tbNumber.Text, tbDefaultPassword.Text, cbPosition.SelectedItem.ToString()));
                
                //invoke inventory add account method
                _classifier = inventory.AddAccount();

                switch (_classifier)
                {
                    case 0:
                        MessageBox.Show(@"Account successfully added", @"Added", MessageBoxButtons.OK
                            , MessageBoxIcon.Information);
                        break;
                    case 1:
                        MessageBox.Show(@"Could not save account", @"DB Error", MessageBoxButtons.OK
                            , MessageBoxIcon.Error);
                        break;
                }

                CleanForm(this); //clear all text-fields
            }
            else
            {
                MessageBox.Show(@"Fill out all fields", @"Empty fields", MessageBoxButtons.OK
                    , MessageBoxIcon.Information);
            }

        }

        private bool CheckEmptyFields()
        {
            var fields = new string[7];
            fields[0] = tbFirstName.Text;
            fields[1] = tbLastName.Text;
            if(cbGender.SelectedItem != null) fields[2] = cbGender.SelectedItem.ToString().ToUpper();
            fields[3] = tbUsername.Text;
            fields[4] = tbNumber.Text;
            fields[5] = tbDefaultPassword.Text;
            if(cbPosition.SelectedItem != null) fields[6] = cbPosition.SelectedItem.ToString().ToUpper();
            for (var i = 0; i < 7; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                    return true;
            }

            return false;
        }

        private void CleanForm(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = string.Empty;
                CleanForm(c);
            }
        }

        private void Back(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(pictureBack,"Go back");
        }

        private void tbFirstName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFirstName.Text)) return;
            var user = string.Concat(UpperCaseFirstChar(tbFirstName.Text.Trim()), tbLastName.Text.Trim());
            tbUsername.Text = user;
        }

        private void tbLastName_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbLastName.Text)) return;
            var user = string.Concat(tbFirstName.Text.Trim(), UpperCaseFirstChar(tbLastName.Text.Trim()));
            tbUsername.Text = user;
        }

        private string UpperCaseFirstChar(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1);
        }

        private void showPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbDefaultPassword.UseSystemPasswordChar = false;
        }

        private void showPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbDefaultPassword.UseSystemPasswordChar = true;
        }
    }
}

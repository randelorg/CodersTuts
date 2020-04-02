using System;
using System.Drawing.Text;
using System.Linq;
using System.Media;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;

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

        private void GenPass_MouseHover(object sender, EventArgs e) => lbGenPass.Show();
        private void GenPass_MouseLeave(object sender, EventArgs e) => lbGenPass.Hide();
        private void pictureBack_Click(object sender, EventArgs e) => this.Close();

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            
            InventoryUtils.LtStaff.AddLast(new Staff(tbFirstName.Text, tbLastName.Text,
                    cbGender.SelectedItem.ToString(), tbUsername.Text,
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

        }

        private bool CheckEmptyFields()
        {
            string[] fields = new string[7];
            fields[0] = tbFirstName.Text;
            fields[1] = tbLastName.Text;
            fields[2] = cbGender.SelectedItem.ToString();
            fields[3] = tbUsername.Text;
            fields[4] = tbNumber.Text;
            fields[5] = tbDefaultPassword.Text;
            fields[6] = cbPosition.SelectedItem.ToString();
            /*for (int i = 0; i < 7; i++)
            {
                if(fields[i])
            }*/

            return true;
        }

        private void ClearFields()
        {
            //clear the fields here
        }
    }
}

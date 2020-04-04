using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;

namespace DellRainInventorySystem
{
    public partial class YourAccount : Form
    {
        private Inventory inventory = new Inventory();
        private SqlConnection con = new SqlConnection(
            "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=RANDEL-PC");
        private SqlCommand cmd;
        private SqlDataReader _reader;
        private string password;

        public YourAccount()
        {
            InitializeComponent();
            PrepFieldsValue();
            ReadyChange();
        }

        private void PrepFieldsValue()
        {
            tbFirstName.Text = Inventory.Firstname;
            tbLastName.Text = Inventory.Lastname;
            tbPosition.Text = inventory.SessAccType.ToUpper();
            btnChangePassword.Enabled = false;
        }
       

        private void tbOldPassword_TextChanged(object sender, EventArgs e)
        {
            // Console.WriteLine(@"password {0}", password);
            if (password.Equals(tbOldPassword.Text))
            {
                tbOldPassword.BackColor = Color.Green;
                btnChangePassword.Enabled = true;
            }
            else
            {
                tbOldPassword.BackColor = Color.Red;
            }
        }

        private void ReadyChange()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText =
                    "SELECT * FROM Inventory.Account WHERE firstname = @fname AND lastname = @lname";
                cmd.Parameters.AddWithValue("@fname", Inventory.Firstname);
                cmd.Parameters.AddWithValue("@lname", Inventory.Lastname);

                _reader = cmd.ExecuteReader();

                if (_reader.Read())
                {
                    password = _reader["password"].ToString();
                }
            }
            catch (SqlException)
            {
                Console.WriteLine(@"Error 404");
            }
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            password = string.Empty;
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            int classifier = -1;

            if(!string.IsNullOrEmpty(tbConfirmNewPassword.Text))
                classifier = inventory.ChangePassword(password, tbConfirmNewPassword.Text);

            switch (classifier)
            {
                case 0:
                    MessageBox.Show(@"Password is changed", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show(@"Connection Error", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
            }
        }

        private void tbConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            tbConfirmNewPassword.BackColor = tbConfirmNewPassword.Text.Equals(tbNewPassword.Text) ? Color.Green : Color.Red;
        }

    }
}

using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Hashing;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class YourAccount : Form
    {
        //connection string

        private SqlDataReader _reader;
        private SqlCommand cmd;
        private readonly SqlConnection con = new SqlConnection(Connect.MainConn);

        private readonly Inventory inventory = new Inventory();
        private NewAccount account = new NewAccount();
        private string password;

        public YourAccount()
        {
            InitializeComponent();
            PrepFieldsValue();
            ReadyChange();
        }

        private void PrepFieldsValue()
        {
            tbFirstName.Text = InventoryUtils.Firstname;
            tbLastName.Text = InventoryUtils.Lastname;
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
                cmd.Parameters.AddWithValue("@fname", InventoryUtils.Firstname);
                cmd.Parameters.AddWithValue("@lname", InventoryUtils.Lastname);

                _reader = cmd.ExecuteReader();

                if (_reader.Read()) password = Hash.Decode(_reader["password"].ToString());
            }
            catch (SqlException)
            {
                Console.WriteLine(@"Error 404");
            }
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            password = string.Empty;
            Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var classifier = -1;

            if (!string.IsNullOrEmpty(tbConfirmNewPassword.Text))
                classifier = account.ChangePassword(password, tbConfirmNewPassword.Text);

            switch (classifier)
            {
                case 0:
                    MessageBox.Show(@"Password is changed", @"Success", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    CleanForm();
                    break;
                case 1:
                    MessageBox.Show(@"Connection Error", @"Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    break;
            }
        }

        private void tbConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            tbConfirmNewPassword.BackColor =
                tbConfirmNewPassword.Text.Equals(tbNewPassword.Text) ? Color.Green : Color.Red;
        }

        private void CleanForm()
        {
            tbOldPassword.Text = string.Empty;
            tbNewPassword.Text = string.Empty;
            tbConfirmNewPassword.Text = string.Empty;
        }

        private void Back(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(pictureBack, "Go back");
        }
    }
}
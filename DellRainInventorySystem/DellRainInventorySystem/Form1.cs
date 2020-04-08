using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class Form1 : Form
    {
        //connection string
        private SqlConnection con = new SqlConnection(Connect.MainConn);
        private SqlDataReader _reader;
        private SqlCommand cmd;

        private Inventory inventory = new Inventory();

        public Form1()
        {
            InitializeComponent();
            ClearLinkList();//clear all the link-list available
        }

        //will close the login window
        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();

        private void ShowDashboard()
        {
            var dashboard = new Index();
            dashboard.Hide();
            this.Hide();
            dashboard.ShowDialog();
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //sql query
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                //sql query
                cmd.CommandText = "SELECT * FROM Inventory.Account WHERE username = @username AND password = @password";
                cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                cmd.Parameters.AddWithValue("@password", tbPassword.Text);

                _reader = cmd.ExecuteReader();

                if (_reader.Read())
                {
                    /*stores the full name of the user and account type in the session holder
                    sets the session for the current user*/
                    inventory.Session(_reader["firstname"].ToString() + " " + _reader["lastname"].ToString(),
                        _reader["accType"].ToString().ToUpper()); 
                    InventoryUtils.Firstname = _reader["firstname"].ToString();
                    InventoryUtils.Lastname = _reader["Lastname"].ToString();

                    ShowDashboard();
                }
                else
                    MessageBox.Show(@"Username or password is incorrect", @"Invalid", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (SqlException a)
            {   
                Debug.WriteLine(a.ToString());
                MessageBox.Show(@"Cannot connect to the database", @"Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            finally{ con.Close();}
        }

        private void ClearLinkList()
        {
            InventoryUtils.LtuUsers.Clear();
            InventoryUtils.LtProducts.Clear();
            InventoryUtils.ExistingLocation.Clear();
            InventoryUtils.ExistingSuppliers.Clear();
        }

        private void Exit(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(pictureBox1,"Exit");
        }
    }
}

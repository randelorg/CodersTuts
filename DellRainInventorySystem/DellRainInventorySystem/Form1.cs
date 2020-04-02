using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;

namespace DellRainInventorySystem
{
    public partial class Form1 : Form
    {
        private Inventory inventory = new Inventory();
        private SqlDataReader _reader;
        private SqlConnection con;
        private SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
            //connection string
            con = new SqlConnection(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=RANDELLAPPY");
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
                    //select the row of the current username
                    cmd.CommandText = "SELECT * FROM Inventory.Account WHERE usernmae = @username";
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);

                    //stores the full name of the user and account type in the session holder
                    inventory.Session(_reader["firstname"].ToString() + " " + _reader["lastname"].ToString(),
                        _reader["accType"].ToString().ToLower()); //sets the session
                    Inventory.Firstname = _reader["firstname"].ToString();
                    Inventory.Lastname = _reader["Lastname"].ToString();

                    ShowDashboard();//open the dashboard window
                }
                else
                    MessageBox.Show(@"Username or password is incorrect", @"Invalid", 
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (SqlException a)
            {   //connection string for my pc
                con = new SqlConnection(
                    "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=RANDEL-PC");
                Debug.WriteLine(a.ToString());
                MessageBox.Show(@"Cannot connect to the database", @"Error", 
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            finally{ con.Close();}
        }

    }
}

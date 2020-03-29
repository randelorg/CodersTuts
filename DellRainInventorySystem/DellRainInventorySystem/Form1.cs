using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;

namespace DellRainInventorySystem
{
    public partial class Form1 : Form
    {
        private Inventory clInventory = new Inventory();
        private SqlDataReader _reader;
        private SqlConnection con;
        private SqlCommand cmd;
        
        public Form1()
        {
            InitializeComponent();
            //connection string
            con = new SqlConnection(
                "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=RANDEL-PC");
        }
        
        //will close the login window
        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //sql query
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                //sql query
                cmd.CommandText = "SELECT * FROM Inventory.Account WHERE username='" + this.tbUsername.Text +
                                  "' AND password='" + this.tbPassword.Text + "'";
                _reader = cmd.ExecuteReader();

                if (_reader.Read())
                {
                    //sets the session
                    clInventory.Session(tbUsername.Text, "admin");
                    //open the index window
                    var Index = new Index();
                    Index.Hide();
                    this.Hide();
                    Index.ShowDialog();
                    this.Close();
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

    }
}

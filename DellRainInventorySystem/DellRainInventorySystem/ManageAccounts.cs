using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class ManageAccounts : Form
    {
        private readonly SqlConnection connection = new SqlConnection(Connect.MainConn);
        private readonly ToolTip tt = new ToolTip();

        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void LoadEverything()
        {
            var binder = new BindingSource();
            var cmd = new SqlCommand();

            try
            {
                connection.Open();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT * FROM Inventory.Account";

                var adapter = new SqlDataAdapter(cmd);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                EmployeeList.DataSource = binder;
                binder.DataSource = dataTable;
            }
            catch (SqlException a)
            {
                Console.WriteLine(a.ToString());
                MessageBox.Show(@"Cant connect to DB", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (FormatException a)
            {
                Console.WriteLine(a.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'inventoryDBDataSet.Account' table. You can move, or remove it, as needed.
                accountTableAdapter.Fill(inventoryDBDataSet.Account);
            }
            catch (SqlException ex)
            {
                LoadEverything();
            }
            
        }

        private void Back(object sender, EventArgs e)
        {
            tt.SetToolTip(pictureBack, "Go back");
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            var binder = new BindingSource();
            var cmd = new SqlCommand();

            if (string.IsNullOrEmpty(tbSearchProduct.Text))
                LoadEverything();

            else
                try
                {
                    connection.Open();
                    cmd.Connection = connection;

                    cmd.CommandText =
                        "SELECT * FROM Inventory.Account WHERE firstname LIKE @omni OR lastname LIKE @omni OR accType LIKE @omni OR gender LIKE @omni";
                    cmd.Parameters.AddWithValue("@omni", @"%" + tbSearchProduct.Text + @"%");

                    var adapter = new SqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    EmployeeList.DataSource = binder;
                    binder.DataSource = dataTable;
                }
                catch (SqlException a)
                {
                    Console.WriteLine(a.ToString());
                    MessageBox.Show(@"Cant connect to DB", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (FormatException a)
                {
                    Console.WriteLine(a.ToString());
                }
                finally
                {
                    connection.Close();
                }
        }

        private void tbSearchProduct_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(tbSearchProduct, "Search Anything");
        }

        private void NewEmployee_Click(object sender, EventArgs e)
        {
            var create = new CreateAccount();
            create.ShowDialog();
        }

        private void NewEmployee_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(NewEmployee, "Add New Employee");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            ManageAccounts_Load(sender, e);
        }
    }
}
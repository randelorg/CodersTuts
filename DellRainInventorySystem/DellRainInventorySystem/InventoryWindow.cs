using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class InventoryWindow : Form
    {
        //connection string
        private readonly SqlConnection con = new SqlConnection(Connect.MainConn);
        private readonly ToolTip tt = new ToolTip();

        public InventoryWindow()
        {
            InitializeComponent();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void InventoryWindow_Load(object sender, EventArgs e)
        {
            LoadEverything();
        }

        private void LoadEverything() //load all the query result in the join
        {
            try
            {
                var binder = new BindingSource();
                var cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT  [product].prodName, [product].prodType, [product].prodQty, [product].prodSold,[product].prodPrice, [location].name,[supplier].suppName FROM Inventory.Product AS product INNER JOIN Inventory.Supplier AS supplier ON [product].Supplier = [supplier].suppId INNER JOIN Inventory.Location AS location  ON [location].locaId = [product].Location";

                DataTable record;
                using (var sdr = new SqlDataAdapter(cmd))
                {
                    record = new DataTable();
                    sdr.Fill(record);
                }

                StockView.DataSource = binder;
                binder.DataSource = record;
            }

            catch (SqlException a)
            {
                Console.WriteLine(a.ToString());
            }

            finally
            {
                con.Close();
            }
        }

        private void pictureBack_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(pictureBack, "Go back");
        }

        private void Refresh_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(Refresh, "Refresh table");
        }

        private void tbSearchProduct_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(tbSearchProduct, "Search by Name, Location, Supplier, Type, Quantity");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            LoadEverything();
        }

        private void tbSearchProduct_TextChanged(object sender, EventArgs e)
        {
            var binder = new BindingSource();
            var cmd = new SqlCommand();

            if (string.IsNullOrEmpty(tbSearchProduct.Text))
                Refresh_Click(sender, e);
            else
                try
                {
                    con.Open();
                    cmd.Connection = con;

                    cmd.CommandText = "SELECT  [product].prodName, [product].prodType, [product].prodQty , [product].prodSold, [product].prodPrice,[location].name,[supplier].suppName FROM Inventory.Product AS product INNER JOIN Inventory.Supplier AS supplier ON [product].Supplier = [supplier].suppId INNER JOIN Inventory.Location AS location  ON [location].locaId = [product].Location WHERE [product].prodname LIKE @omni OR [product].prodType LIKE @omni OR [product].prodQty LIKE @omni OR [location].name LIKE @omni OR [supplier].suppName LIKE @omni";
                    cmd.Parameters.AddWithValue("@omni", @"%" + tbSearchProduct.Text.Trim() + @"%");

                    var adapter = new SqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    StockView.DataSource = binder;
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
                    con.Close();
                }
        }
    }
}
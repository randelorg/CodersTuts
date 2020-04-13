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

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
        }

        private void InventoryWindow_Load(object sender, EventArgs e)
        {
            try
            {
                var binder = new BindingSource();
                var cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText =
                    "SELECT  [product].prodName, [product].prodType, [product].prodQty ,[product].prodPrice, [location].name,[supplier].suppName" +
                    "FROM Inventory.Product AS product INNER JOIN Inventory.Supplier AS supplier ON [product].Supplier = [supplier].suppId" +
                    "INNER JOIN Inventory.Location AS location  ON [location].locaId = [product].Location";

                DataTable record;
                using (var sdr = new SqlDataAdapter(cmd))
                {
                    record = new DataTable();
                    sdr.Fill(record);
                }

                dataView.DataSource = binder;
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

        private void UpdateProduct_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(UpdateProduct, "Update product");
        }

        private void AddProduct_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(AddProduct, "Add product");
        }

        private void pictureBack_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(pictureBack, "Go back");
        }

        private void Refresh_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(Refresh, "Refresh table");
        }
    }
}
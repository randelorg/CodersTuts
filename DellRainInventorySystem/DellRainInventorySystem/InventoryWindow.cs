using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class InventoryWindow : Form
    {
        //connection string
        private static readonly string mainConn = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;
        private SqlConnection con = new SqlConnection(mainConn);

        public InventoryWindow()
        {
            InitializeComponent();
        }

        private void pictureBack_Click(object sender, EventArgs e) => this.Close();

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
        }

        private void InventoryWindow_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                var sqlQuery =
                    "SELECT product.prodName, product.prodType, product.prodQty ,product.prodPrice, location.name, supplier.suppName" +
                    "FROM Inventory.Product AS product INNER JOIN Inventory.Supplier AS supplier ON product.Supplier = supplier.suppId" +
                    "INNER JOIN Inventory.Location AS location ON location.locaId = product.Location";
                var sqlcom = new SqlCommand(sqlQuery, con);
                var sdr = new SqlDataAdapter(sqlcom);

                var dt = new DataTable();
                sdr.Fill(dt);
                dataView.DataSource = dt;
            }

            catch (SqlException a)
            {
                Console.WriteLine(a.ToString());
            }

            finally{ con.Close(); }
        }
    }
}

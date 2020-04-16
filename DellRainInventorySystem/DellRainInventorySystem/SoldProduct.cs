using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class SoldProduct : Form
    {
        private SqlConnection connection = new SqlConnection(Connect.MainConn);
        private ToolTip tt= new ToolTip();
        private Inventory inventory = new Inventory();

        public SoldProduct()
        {
            InitializeComponent();
        }

        private void SoldProduct_Load(object sender, EventArgs e)
        {
            LoadSales();
        }

        private void Refresh_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(Refresh, "Refresh");
        }

        private void pictureBack_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(pictureBack, "Go back");
        }

        private void LoadSales()
        {
            var binder = new BindingSource();
            var cmd = new SqlCommand();

            try
            {
                connection.Open();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT productId, prodName, prodSold, prodType FROM Inventory.Product";

                var adapter = new SqlDataAdapter(cmd);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                SoldView.DataSource = binder;
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

        private void SoldView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //will determine the primary key of the product to be updated
            var selectRow = SoldView.Rows[e.RowIndex];
            InventoryUtils.UpdateProdId = Convert.ToInt32(selectRow.Cells[0].Value);
            Console.WriteLine(@"Prod sold ID {0}", InventoryUtils.UpdateProdId);
            
            //invoke to load the image to the link list
            inventory.LoadForSoldWindow();

            //Display the product image
            var product = InventoryUtils.LtProducts.Last.Value;
            ProductPreview.Image = product.ProdImage;
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var binder = new BindingSource();
            var cmd = new SqlCommand();

            if (string.IsNullOrEmpty(tbSearch.Text))
                SoldProduct_Load(sender, e);
            else
                try
                {
                    connection.Open();
                    cmd.Connection = connection;

                    cmd.CommandText =
                        "SELECT productId, prodName, prodType, prodSold FROM Inventory.Product WHERE prodName LIKE @omni OR prodType LIKE @omni";
                    cmd.Parameters.AddWithValue("@omni", @"%" + tbSearch.Text.Trim() + @"%");

                    var adapter = new SqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    SoldView.DataSource = binder;
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

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(prodQty.Value == 0) return;

            //set the sold number to the current sold qty of the product
            InventoryUtils.SoldNumber = Convert.ToInt32(prodQty.Value.ToString(CultureInfo.InvariantCulture));
            
            //if there is no exception occurs proceed
            //invoke the sold product method
            if (ErrorMsg(inventory.SoldProduct()))
            {
                //notify the user
                //display check image
                Console.WriteLine(@"ADD SOLD PRODUCT");

                prodQty.Value = 0;
            }
        }

        private bool ErrorMsg(int ex)
        {
            switch (ex)
            {
                case 0:
                    return true;
                case 1:
                    MessageBox.Show(@"Cannot connect to the database", @"Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }

            return false;
        }
    }
}

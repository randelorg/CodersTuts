using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class UpdateProductcs : Form
    {
        private readonly SqlConnection connection = new SqlConnection(Connect.MainConn);
        private readonly ToolTip tt = new ToolTip();
        private Inventory inventory = new Inventory();

        public UpdateProductcs()
        {
            InitializeComponent();
        }

        private void UpdateProducts_Load(object sender, EventArgs e)
        {
            LoadProductBasicInfo();
        }
        private void pictureBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbSearch_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(tbSearch, "Search name or product type");
        }

        private void Refresh_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(Refresh, "Refresh");
        }

        private void ProductView_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(ProductView, "Select product to update");
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            UpdateProducts_Load(sender, e);
        }

        private void LoadProductBasicInfo()
        {
            var binder = new BindingSource();
            var cmd = new SqlCommand();

            try
            {
                connection.Open();
                cmd.Connection = connection;

                cmd.CommandText = "SELECT productId, prodName, prodType, prodQty FROM Inventory.Product";

                var adapter = new SqlDataAdapter(cmd);
                var dataTable = new DataTable();
                adapter.Fill(dataTable);

                ProductView.DataSource = binder;
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

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            var binder = new BindingSource();
            var cmd = new SqlCommand();

            if (string.IsNullOrEmpty(tbSearch.Text))
                UpdateProducts_Load(sender, e);
            else
                try
                {
                    connection.Open();
                    cmd.Connection = connection;

                    cmd.CommandText =
                        "SELECT productId, prodName, prodType FROM Inventory.Product WHERE prodName LIKE @omni OR prodType LIKE @omni";
                    cmd.Parameters.AddWithValue("@omni", @"%" + tbSearch.Text.Trim() + @"%");

                    var adapter = new SqlDataAdapter(cmd);
                    var dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    ProductView.DataSource = binder;
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

        private void ProductView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //will determine the primary key of the product to be updated
            var selectRow = ProductView.Rows[e.RowIndex];
            InventoryUtils.UpdateProdId = Convert.ToInt32(selectRow.Cells[0].Value);
            Console.WriteLine(@"Prod ID {0}", InventoryUtils.UpdateProdId);

            //invoke to display the product details
            LoadDetails();
        }

        private void LoadDetails()
        {
            if (ErrorMsg(inventory.PrepareProductToUpdate()))
            {
                if (InventoryUtils.LtUpdateProduct.Count > 0)
                {
                    var product = InventoryUtils.LtUpdateProduct.Last.Value; //get the last added value in the link-list
                    ProductPreview.Image = product.ProdImage;
                    tbName.Text = product.ProdName;
                    tbPrice.Text = product.Price.ToString(CultureInfo.CurrentCulture);
                    tbLocation.Text = product.Location;
                    ShelfLife.Text = product.Shelflife;
                    tbSuppName.Text = product.CompanyName;
                    tbSuppContact.Text = product.Contact;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if(!CheckEmptyFields(this))
                MessageBox.Show(@"Supply all fields", @"Empty fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                InventoryUtils.LtUpdateProduct.AddLast(new Product(ProductPreview.Image,
                    tbName.Text, int.Parse(prodQty.Text),
                    float.Parse(tbPrice.Text),
                    tbLocation.Text, ShelfLife.Text,
                    tbSuppName.Text, tbSuppContact.Text));

                if (ErrorMsg(inventory.UpdateSelectedProduct()))
                {

                }
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

        private bool CheckEmptyFields(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        return string.IsNullOrEmpty(prodQty.Text) || true;
                    }

                    CheckEmptyFields(c);
                }

            return false;
        }

    }
}
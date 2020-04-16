using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;
using DellRainInventorySystem.Properties;

namespace DellRainInventorySystem
{
    public partial class UpdateProductcs : Form
    {
        private readonly SqlConnection connection = new SqlConnection(Connect.MainConn);
        private readonly ToolTip tt = new ToolTip();
        private Inventory inventory = new Inventory();
        private Image _image;

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
                        "SELECT productId, prodName, prodType, prodQty FROM Inventory.Product WHERE prodName LIKE @omni OR prodType LIKE @omni";
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
                    Console.WriteLine(a.Message);
                }
                finally
                {
                    connection.Close();
                }
        }

        private void btnImage_Click_1(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                // Console.WriteLine(@"WOW");
                // filename of the selected image
                _image = new Bitmap(openFileDialog1.FileName);
                btnImage.Text = @"Selected image";
                ProductPreview.ImageLocation = openFileDialog1.FileName;
            }
            Console.WriteLine(result); // <-- For debugging 
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
                if (InventoryUtils.LtProducts.Count > 0)
                {
                    var product = InventoryUtils.LtProducts.Last.Value; //get the last added value in the link-list
                    ProductPreview.Image = product.ProdImage;
                    tbName.Text = product.ProdName;
                    tbPrice.Text = product.Price.ToString("F", CultureInfo.InvariantCulture);
                    tbLocation.Text = product.Location;
                    ShelfLife.Text = product.Shelflife;
                    tbSuppName.Text = product.CompanyName;
                    tbSuppContact.Text = product.Contact;
                }
            }
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            //check if there are empty fields
            if(CheckEmptyFields(this))
                MessageBox.Show(@"Supply all fields", @"Empty fields",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                //add product to the last node of the linked list
                InventoryUtils.LtProducts.AddLast(new Product(ProductPreview.Image,
                    tbName.Text, int.Parse(prodQty.Text),
                    double.Parse(tbPrice.Text),
                    tbLocation.Text, ShelfLife.Text,
                    tbSuppName.Text, tbSuppContact.Text));

                //call add supplier to check or add supplier details
                ErrorMessage(inventory.AddSupplier());

                //call add location to check or add location details
                ErrorMessage(inventory.AddLocation());

                //if the there are no exception occur proceed
                //if there are new uploaded image set it to the Image object
                if (btnImage.Text.Contains("Selected image"))
                        ProductPreview.Image = _image; //sets the image

                //add product to the last node of the linked list
                //and ready for updating the product
                InventoryUtils.LtProducts.AddLast(new Product(ProductPreview.Image, tbName.Text,
                    int.Parse(prodQty.Text),
                    double.Parse(tbPrice.Text), ShelfLife.Text, tbSuppContact.Text));

                //if exception occurs return and display err msg
                //invoke the method from the inventory class
                if(!ErrorMsg(inventory.UpdateSelectedProduct())) return;

                //when product is successfully updated
                MessageBox.Show(@"Product is updated", @"Updated",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                //lastly clean the form
                CleanForm(this);
                ProductView.ClearSelection();
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

        private void ErrorMessage(int i)
        {
            // 1 for adding location and 2 for adding supplier error
            switch (i)
            {
                case 1:
                    MessageBox.Show(@"Could not save product location", @"DB Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show(@"Could not save product supplier", @"DB Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    break;
            }
        }

        private bool CheckEmptyFields(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(c.Text))
                    {
                        if(c.Name.Equals("tbSearch"))
                            continue;
                        return true;
                    }

                    CheckEmptyFields(c);
                }

            return false;
        }

        private void CleanForm(Control ctrl)
        {
            var i = 0;

            foreach (Control c in ctrl.Controls)
            {
                ++i;
                if (i == 1)
                {
                    btnImage.Text = @"Upload New Image";
                    ProductPreview.Image = Resources.Photo;
                    prodQty.Value = 0;
                }

                if (ctrl is TextBox) ((TextBox)c).Text = string.Empty;
                CleanForm(c);
            }
        }

    }
}
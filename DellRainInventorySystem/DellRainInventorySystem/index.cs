using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;

namespace DellRainInventorySystem
{
    public partial class Index : Form
    {
        private readonly Inventory inventory = new Inventory();
        private Form1 Login = new Form1();
        private readonly ToolTip tt = new ToolTip();

        public Index()
        {
            var t = new Thread(splash);
            t.Start();
            Thread.Sleep(1000);

            InitializeComponent();
            //display the username of the login user
            lbUsername.Text = inventory.SessUsername;

            DetermineAccountType();
            RemoveBorder();

            try
            {
                t.Abort();
            }
            catch (ThreadAbortException e)
            {
                e.ToString();
            }
        }

        private void splash()
        {
            Application.Run(new SplashScreen());
        }

        private void DetermineAccountType()
        {
            const string staffAccType = "STAFF";

            switch (inventory.SessAccType)
            {
                case staffAccType:
                    btnListAccounts.Hide();
                    btnCreateAccount.Hide();
                    break;
            }
        }

        private void RemoveBorder()
        {
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnYourAccount.FlatAppearance.BorderSize = 0;
            btnListAccounts.FlatAppearance.BorderSize = 0;
            TopSellingView.BorderStyle = BorderStyle.None;
            DangerProductsView.BorderStyle = BorderStyle.None;
        }

        //mouse events
        private void btnYourAccount_MouseHover(object sender, EventArgs e)
        {
            btnYourAccount.ForeColor = Color.White;
        }

        private void btnYourAccount_MouseLeave(object sender, EventArgs e)
        {
            btnYourAccount.ForeColor = Color.Gray;
        }

        private void btnCreateAccount_MouseHover(object sender, EventArgs e)
        {
            btnCreateAccount.ForeColor = Color.White;
        }

        private void btnCreateAccount_MouseLeave(object sender, EventArgs e)
        {
            btnCreateAccount.ForeColor = Color.Gray;
        }

        private void btnListAccounts_MouseHover(object sender, EventArgs e)
        {
            btnListAccounts.ForeColor = Color.White;
        }

        private void btnListAccounts_MouseLeave(object sender, EventArgs e)
        {
            btnListAccounts.ForeColor = Color.Gray;
        }

        private void closeButton_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(closeButton, "Logout");
        }

        private void SalesReport_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(SalesReports, "Generate Reports");
        }

        private void Stock_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(Stock, "Stock");
        }

        private void Reload_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(Reload, "Refresh");
        }

        //click events
        private void btnYourAccount_Click(object sender, EventArgs e)
        {
            var account = new YourAccount();
            account.ShowDialog();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var createAccount = new CreateAccount();
            createAccount.ShowDialog();
        }

        private void Stock_Click(object sender, EventArgs e)
        {
            var inventoryWindow = new InventoryWindow();
            inventoryWindow.ShowDialog();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            var login = new Form1();
            login.Hide();
            Hide();
            login.ShowDialog();
            Close();
        }

        private void SalesReports_Click(object sender, EventArgs e)
        {
            var reports = new Reports();
            reports.ShowDialog();
        }

        private void btnListAccounts_Click(object sender, EventArgs e)
        {
            var manageAccounts = new ManageAccounts();
            manageAccounts.ShowDialog();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            //for low stock products
            if (inventory.DetermineProductInThresholdLevel()) //if returns true Database connection error
                ErrorMessage();
            else
                LoadThresholdProducts();

            //for top selling products
            if (inventory.DetermineTopSellingProducts())
                ErrorMessage();
            else
                LoadTopSellingProducts();

            //for the total qty of groceries
            LoadGroceryQty();

            //for the total qty of appliances
            LoadProductQty();
        }

        private void ErrorMessage()
        {
            MessageBox.Show(@"There is a problem connecting to the database", @"Connection Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LoadThresholdProducts()
        {
            if (imageList1.Images.Count > 0)
                imageList1.Images.Clear();

            foreach (var t in InventoryUtils.LowOnStock) imageList1.Images.Add(t);

            //clear list view if it does have a content 
            //to prevent image duplication
            if (DangerProductsView.Items.Count > 0)
                DangerProductsView.Items.Clear();

            for (var j = 0; j < imageList1.Images.Count; j++)
            {
                var item = new ListViewItem();
                item.ImageIndex = j;
                DangerProductsView.Items.Add(item);
            }
        }

        private void LoadTopSellingProducts()
        {
            if (imageList2.Images.Count > 0)
                imageList2.Images.Clear();

            foreach (var t in InventoryUtils.TopSelling) imageList2.Images.Add(t);

            //clear list view if it does have a content 
            //to prevent image duplication
            if (TopSellingView.Items.Count > 0)
                TopSellingView.Items.Clear();

            for (var j = 0; j < imageList2.Images.Count; j++)
            {
                var item = new ListViewItem();
                item.ImageIndex = j;
                TopSellingView.Items.Add(item);
            }
        }

        private void LoadGroceryQty()
        {
            var groceryQty = inventory.CountGroceriesProductsQty();
            if (groceryQty > 0)
                tbGroceriesTotalQty.Text = groceryQty.ToString();
            else
                ErrorMessage();
        }

        private void LoadProductQty()
        {
            var productQty = inventory.CountApplianceProductsQty();
            if (productQty > 0)
                tbAppliancesTotalQty.Text = productQty.ToString();
            else
                ErrorMessage();
        }

        private void Reload_Click(object sender, EventArgs e)
        {
            Index_Load(sender, e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Reload_Click(sender,e);
        }

        private void AddProduct_Click(object sender, EventArgs e)
        {
            var addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
        }

        private void AddProduct_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(AddProduct, "New Product");
        }

        private void UpdateProduct_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(UpdateProduct, "Update Product");
        }

        private void SoldProducts_MouseHover(object sender, EventArgs e)
        {
            tt.SetToolTip(SoldProducts, "Update Sold Products");
        }

        private void UpdateProduct_Click(object sender, EventArgs e)
        {
            var updateProd = new UpdateProductcs();
            updateProd.ShowDialog();
        }
    }
}
﻿using System;
using System.Drawing;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;

namespace DellRainInventorySystem
{
    public partial class Index : Form
    {
        private Inventory inventory = new Inventory();
        private Form1 Login = new Form1();
        
        public Index()
        {
            InitializeComponent();
            lbUsername.Text = inventory.SessUsername; //display the username of the login user

            DetermineAccountType();
            BgColor(); 
            RemoveBorder();
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

        private void BgColor()
        {
            bg1.BackColor = Color.FromArgb(26,95,149);
            bg2.BackColor = Color.FromArgb(46, 187, 163);
            bgTools.BackColor = Color.FromArgb(115, 187, 163);
            lbReports.BackColor = Color.FromArgb(46, 187, 163);
            lbInventory.BackColor = Color.FromArgb(26, 95, 149);
        }

        private void RemoveBorder()
        {
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnYourAccount.FlatAppearance.BorderSize = 0;
            btnListAccounts.FlatAppearance.BorderSize = 0;
            bg1.FlatAppearance.BorderSize = 0;
            bg2.FlatAppearance.BorderSize = 0;
            bg1.FlatAppearance.BorderSize = 0;
            bg2.FlatAppearance.BorderSize = 0;
            bgTools.FlatAppearance.BorderSize = 0;
            TopSellingView.BorderStyle = BorderStyle.None;
            DangerProductsView.BorderStyle = BorderStyle.None;
        }

        //mouse events
        private void btnYourAccount_MouseHover(object sender, EventArgs e) => btnYourAccount.ForeColor = Color.White;
        private void btnYourAccount_MouseLeave(object sender, EventArgs e) => btnYourAccount.ForeColor = Color.Gray;
        private void btnCreateAccount_MouseHover(object sender, EventArgs e) => btnCreateAccount.ForeColor = Color.White;
        private void btnCreateAccount_MouseLeave(object sender, EventArgs e) => btnCreateAccount.ForeColor = Color.Gray;
        private void btnListAccounts_MouseHover(object sender, EventArgs e) => btnListAccounts.ForeColor = Color.White;
        private void btnListAccounts_MouseLeave(object sender, EventArgs e) => btnListAccounts.ForeColor = Color.Gray;
        private void closeButton_MouseHover(object sender, EventArgs e) => lbLogout.Show();
        private void closeButton_MouseLeave(object sender, EventArgs e) => lbLogout.Hide();
        private void SalesReport_MouseHover(object sender, EventArgs e) => lbReports.Show();
        private void SalesReports_MouseLeave(object sender, EventArgs e) => lbReports.Hide();
        private void Inventory_MouseHover(object sender, EventArgs e) => lbInventory.Show();
        private void Inventory_MouseLeave(object sender, EventArgs e) => lbInventory.Hide();

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

        private void Inventory_Click(object sender, EventArgs e)
        {
            var inventoryWindow = new InventoryWindow();
            inventoryWindow.ShowDialog();
        }

        private void closeButton_Click_1(object sender, EventArgs e)
        {
            var login = new Form1();
            login.Hide();
            this.Hide();
            login.ShowDialog();
            this.Close();
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
            if(inventory.DetermineTopSellingProducts())
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
            foreach (var t in InventoryUtils.LowOnStock)
            {
                imageList1.Images.Add(t);
            }

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
            foreach (var t in InventoryUtils.TopSelling)
            {
                imageList2.Images.Add(t);
            }

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
    }
}

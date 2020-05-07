using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class Form1 : Form
    {
        //connection string
        private readonly SqlConnection con = new SqlConnection(Connect.MainConn);

        private readonly Inventory inventory = new Inventory();
        private readonly NewAccount auth = new NewAccount();

        public Form1()
        {
            InitializeComponent();
            ClearLinkList(); //clear all the link-list available
        }

        //will close the login window
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowDashboard()
        {
            var dashboard = new Index();
            dashboard.Hide();
            Hide();
            dashboard.ShowDialog();
            Close();
        }


        private void btnLogin_Click(object sender, EventArgs e)
        {
            switch (auth.Login(tbUsername.Text, tbPassword.Text))
            {
                case "success": //if login is successful
                    ShowDashboard();
                    break;

                case "failed"://if login details is incorrect
                    MessageBox.Show(@"Your username or password is incorrect.", @"Incorrect",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                   break;

                case "error"://if have an exception
                    MessageBox.Show(@"Opps! Something went wrong.", @"Error", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ClearLinkList()
        {
            InventoryUtils.LtuUsers.Clear();
            InventoryUtils.LtProducts.Clear();
            InventoryUtils.ExistingLocation.Clear();
            InventoryUtils.ExistingSuppliers.Clear();
        }

    }
}
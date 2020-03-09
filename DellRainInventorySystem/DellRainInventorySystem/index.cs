﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class index : Form
    {
        public index()
        {
            InitializeComponent();
            lbUsername.Text = "Randel P. Reyes";
            bgColor();
            removeBorder();
        }


        private void closeButton_Click(object sender, EventArgs e) => this.Close();

        private void bgColor()
        {
            bg1.BackColor = Color.FromArgb(26,95,149);
            bg2.BackColor = Color.FromArgb(46, 187, 163);
            bgTools.BackColor = Color.FromArgb(115, 187, 163);
            lbReports.BackColor = Color.FromArgb(46, 187, 163);
            lbInventory.BackColor = Color.FromArgb(26, 95, 149);
        }

        private void removeBorder()
        {
            btnCreateAccount.FlatAppearance.BorderSize = 0;
            btnYourAccount.FlatAppearance.BorderSize = 0;
            bg1.FlatAppearance.BorderSize = 0;
            bg2.FlatAppearance.BorderSize = 0;
            bg1.FlatAppearance.BorderSize = 0;
            bg2.FlatAppearance.BorderSize = 0;
            bgTools.FlatAppearance.BorderSize = 0;
        }

        private void btnYourAccount_MouseHover(object sender, EventArgs e) => btnYourAccount.ForeColor = Color.White;

        private void btnYourAccount_MouseLeave(object sender, EventArgs e) => btnYourAccount.ForeColor = Color.Gray;

        private void btnCreateAccount_MouseHover(object sender, EventArgs e) => btnCreateAccount.ForeColor = Color.White;

        private void btnCreateAccount_MouseLeave(object sender, EventArgs e) => btnCreateAccount.ForeColor = Color.Gray;

        private void closeButton_MouseHover(object sender, EventArgs e) => lbLogout.Show();

        private void closeButton_MouseLeave(object sender, EventArgs e) => lbLogout.Hide();

        private void SalesReport_MouseHover(object sender, EventArgs e) => lbReports.Show();

        private void SalesReports_MouseLeave(object sender, EventArgs e) => lbReports.Hide();

        private void Inventory_MouseHover(object sender, EventArgs e) => lbInventory.Show();

        private void Inventory_MouseLeave(object sender, EventArgs e) => lbInventory.Hide();

        private void btnYourAccount_Click(object sender, EventArgs e)
        {
            YourAccount account = new YourAccount();
            account.Show();
        }
    }
}
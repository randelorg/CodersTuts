﻿using DellRainInventorySystem.Classes;
using System;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class AddProductWindow : Form
    {
        private Inventory inventory = new Inventory();
        private string[] fields = new string[8];

        public AddProductWindow()
        {
            InitializeComponent();
            PrepList();
        }

        private void PrepList()
        {
            ShelfLife.CustomFormat = @"dd-MMM-yyyy";
            ShelfLife.Format = DateTimePickerFormat.Custom;
        }

        private void pictureBack_Click(object sender, EventArgs e) => this.Close();

        private void btnSaveProduct_Click(object sender, EventArgs e)
        {

            if (!CheckEmptyFields())
            {
                InventoryUtils.LtProducts.AddLast(new Product(fields[0], fields[1], int.Parse(fields[2]), float.Parse(fields[3]), fields[4], fields[5],
                                                    fields[6], fields[7]));

                ErrorMessage(inventory.AddProduct()); //add the whole product

                CleanForm(this);
            }
            else
            {
                Console.WriteLine(@"Empty");
            }
        }

        private bool CheckEmptyFields()
        {

            fields[0] = tbName.Text; //product name
            if (cbProductType.SelectedItem != null)                   //product
                fields[1] = cbProductType.SelectedItem.ToString();    //  type

            fields[2] = prodQty.Text; //product quantity
            fields[3] = tbPrice.Text; //product price

            if (!string.IsNullOrEmpty(tbLocation.Text))     //product location
                fields[4] = tbLocation.Text;
            else
            {
                if (cbProductLocation.SelectedItem != null)
                    fields[4] = cbProductLocation.SelectedItem.ToString();
            }

            fields[5] = ShelfLife.Text;     //product shelf life in date
            Console.WriteLine(@"Date {0}", fields[5]);

            if (!string.IsNullOrEmpty(tbSuppName.Text))
            {   //supplier name
                fields[6] = tbSuppName.Text;
            }
            else
            {
                if (cbListOfSupplier.SelectedItem != null)
                    fields[6] = cbListOfSupplier.SelectedItem.ToString();
            }

            fields[7] = tbSuppContact.Text; //supplier contact

            for (var i = 0; i < 8; i++)
            {
                if (string.IsNullOrEmpty(fields[i]))
                    return true;
            }

            return false;
        }

        private void CleanForm(Control ctrl)
        {
            foreach (Control c in ctrl.Controls)
            {
                if (c is TextBox) ((TextBox)c).Text = string.Empty;
                CleanForm(c);
            }
        }

        //user interactive control
        private void tbLocation_TextChanged(object sender, EventArgs e)
        {
            cbProductLocation.Enabled = string.IsNullOrEmpty(tbLocation.Text);
        }

        private void tbSuppName_TextChanged(object sender, EventArgs e)
        {
            cbListOfSupplier.Enabled = string.IsNullOrEmpty(tbSuppName.Text);
        }

        private void cbListOfSupplier_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbListOfSupplier.SelectedIndex >= 0)
                tbSuppName.Enabled = false;
        }

        private void cbProductLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProductLocation.SelectedIndex >= 0)
                tbLocation.Enabled = false;
        }

        private void ErrorMessage(int i)
        {
            switch (i)
            {
                case 0:
                    MessageBox.Show(@"Product successfully added", @"Product Added", MessageBoxButtons.OK
                        , MessageBoxIcon.Information);
                    break;
                case 1:
                    MessageBox.Show(@"Could not save product", @"DB Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    break;
            }
        }
    }
}

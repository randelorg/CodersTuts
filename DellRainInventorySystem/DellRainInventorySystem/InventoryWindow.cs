using System;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class InventoryWindow : Form
    {
        public InventoryWindow()
        {
            InitializeComponent();
        }

        private void pictureBack_Click(object sender, EventArgs e) => this.Close();

        private void AddProduct_Click(object sender, EventArgs e)
        {
            AddProductWindow addProductWindow = new AddProductWindow();
            addProductWindow.ShowDialog();
        }
    }
}

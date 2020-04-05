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

        private void InventoryWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Product' table. You can move, or remove it, as needed.
            this.productTableAdapter.Fill(this.inventoryDBDataSet.Product);

        }
    }
}

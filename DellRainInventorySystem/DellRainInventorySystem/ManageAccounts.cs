using System;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Account' table. You can move, or remove it, as needed.
            accountTableAdapter.Fill(inventoryDBDataSet.Account);
        }

        private void Back(object sender, EventArgs e)
        {
            var tt = new ToolTip();
            tt.SetToolTip(pictureBack, "Go back");
        }


    }
}
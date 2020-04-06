using System;
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
    public partial class ManageAccounts : Form
    {
        public ManageAccounts()
        {
            InitializeComponent();
        }

        private void ManageAccounts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'inventoryDBDataSet.Account' table. You can move, or remove it, as needed.
            this.accountTableAdapter.Fill(this.inventoryDBDataSet.Account);

        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

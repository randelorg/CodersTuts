using System;
using System.Windows.Forms;
using DellRainInventorySystem.Classes;

namespace DellRainInventorySystem
{
    public partial class YourAccount : Form
    {
        private Inventory inventory = new Inventory();
        public YourAccount()
        {
            InitializeComponent();
            PrepFieldsValue();
        }

        private void PrepFieldsValue()
        {
            tbFirstName.Text = Inventory.Firstname;
            tbLastName.Text = Inventory.Lastname;
            tbPosition.Text = inventory.SessAccType.ToUpper();
        }

        private void pictureBack_Click(object sender, EventArgs e) => this.Close();
    }
}

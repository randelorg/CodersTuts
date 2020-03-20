using System;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class AddProductWindow : Form
    {
        public AddProductWindow()
        {
            InitializeComponent();
        }

        private void pictureBack_Click(object sender, EventArgs e) => this.Close();
    }
}

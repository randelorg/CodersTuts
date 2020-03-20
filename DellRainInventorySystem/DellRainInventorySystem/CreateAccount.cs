using System;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void GenPass_MouseHover(object sender, EventArgs e) => lbGenPass.Show();
        private void GenPass_MouseLeave(object sender, EventArgs e) => lbGenPass.Hide();

        private void pictureBack_Click(object sender, EventArgs e) => this.Close();
    }
}

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
    public partial class YourAccount : Form
    {
        public YourAccount()
        {
            InitializeComponent();
            this.changeBackColor();
            this.removeBorder();
        }

        private void changeBackColor()
        {
            bgUser.BackColor = Color.FromArgb(185,29,86);
            bgChangePassword.BackColor = Color.FromArgb(220, 171, 18);
        }

        private void removeBorder()
        {
            bgUser.FlatAppearance.BorderSize = 0;
            bgChangePassword.FlatAppearance.BorderSize = 0;
        }

        private void disableButton()
        {
            bgChangePassword
        }

        private void close_Click(object sender, EventArgs e) => this.Close();
    }
}

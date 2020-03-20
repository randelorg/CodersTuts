using System;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //will close the login window
        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Index index = new Index();
            index.Show();
        }


    }
}

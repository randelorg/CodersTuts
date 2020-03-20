using System;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class Form1 : Form
    {
        private String Username = @"randel";
        private String Password = @"1234";
        
        public Form1()
        {
            InitializeComponent();
        }
        //will close the login window
        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Auth())
            {
                Index index = new Index();
                index.Show();
            }
            else
                MessageBox.Show(@"wrong credentials", @"Invalid", MessageBoxButtons.OK);
        }

        private Boolean Auth()
        {
            return tbUsername.Text.Equals(this.Username) && tbPassword.Text.Equals(this.Password);
        }


    }
}

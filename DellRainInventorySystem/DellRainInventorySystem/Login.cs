using System;
using System.Diagnostics;
using System.Windows.Forms;
using DellRainInventorySystem.SQL;

namespace DellRainInventorySystem
{
    public partial class Form1 : Form
    {
        private Connect link = new Connect();
        private readonly String Username = @"randel";
        private readonly String Password = @"1234";
        
        public Form1()
        {
            InitializeComponent();
        }
        
        //will close the login window
        private void pictureBox1_Click(object sender, EventArgs e) => this.Close();
        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            link.Conn();
            Debug.WriteLine("test");
            if (Auth())
            {
                //open the index window
                var Index = new Index();
                Index.Hide();
                this.Hide();
                Index.ShowDialog();
                this.Close();
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

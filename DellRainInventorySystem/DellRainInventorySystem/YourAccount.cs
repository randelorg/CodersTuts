﻿using System;
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
        }
    
        private void pictureBack_Click(object sender, EventArgs e) => this.Close();
    }
}

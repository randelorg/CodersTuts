﻿using System;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 20;

            if (progressBar1.Value == 100)
                timer1.Stop();
        }
    }
}
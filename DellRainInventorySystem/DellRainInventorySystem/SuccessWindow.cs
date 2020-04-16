using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DellRainInventorySystem
{
    public partial class SuccessWindow : Form
    {
        public SuccessWindow()
        {
            var t = new Thread(success);
            InitializeComponent();

            t.Start();
            Thread.Sleep(2000);
            t.Abort();
            Close();
        }

        private void success()
        {
            try
            {
                Application.Run(this);
            }
            catch (ThreadAbortException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

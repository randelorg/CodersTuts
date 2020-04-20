using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DellRainInventorySystem.Classes;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;

namespace DellRainInventorySystem
{
    public partial class ReportsWindow : Form
    {
        private SqlConnection con = new SqlConnection(Connect.MainConn);
        private SqlCommand cmd;
        BindingSource binder = new BindingSource();

        public ReportsWindow()
        {
            InitializeComponent();
        }

        private void pictureBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveAccount_Click(object sender, EventArgs e)
        {
            //initiate report class 
            var repo = new Report(From.Text, To.Text);

            //invoke sales reports method
            var total = repo.SalesReport();

            /*if there are exception occurs
              if there is no sales occured time given time-frame*/
            switch (total)
            {
                case -1:
                    MessageBox.Show(@"There is a problem connecting to the database", @"Connection Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                case -2:
                    MessageBox.Show(@"There is no sales occured in this time-frame", @"Connection Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }

            //display the total sales in the time frame provided
            TotalSales.Text = total.ToString("F", CultureInfo.InvariantCulture);

            //load data grid
            LoadTable();

            LoadGraph();

        }

        private void LoadGraph()
        {
            Chart.Series["Sales"].XValueMember = "date";
            Chart.Series["Sales"].XValueType = ChartValueType.Date;
            Chart.Series["Sales"].YValueMembers = "sales";
            Chart.Series["Sales"].YValueType= ChartValueType.Double;
            Chart.DataSource = binder;
            Chart.DataBind();
        }

        private void LoadTable()
        {
            try
            {
               
                cmd = new SqlCommand();
                cmd.Connection = con;

                cmd.CommandText = "SELECT DISTINCT sales, date FROM Inventory.Sales WHERE date BETWEEN @from AND @to ORDER BY date ASC";
                cmd.Parameters.AddWithValue("@from", From.Text);
                cmd.Parameters.AddWithValue("@to", To.Text);

                DataTable record;
                using (var sdr = new SqlDataAdapter(cmd))
                {
                    record = new DataTable();
                    sdr.Fill(record);
                }

                dataGridView1.DataSource = binder;
                binder.DataSource = record;
            }

            catch (SqlException a)
            {
                Console.WriteLine(a.ToString());
            }

            finally
            {
                con.Close();
            }
        }

    }
}

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using DellRainInventorySystem.Interfaces;

namespace DellRainInventorySystem.Classes
{
    internal class Report: Inventory, IReports
    {
        private string From;
        private string To;

        public Report() { }
        public Report(string from, string to)
        {
            From = from;
            To = to;
        }

        public double SalesReport()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT SUM(sales) FROM  Inventory.Sales WHERE date BETWEEN @from AND @to";
                cmd.Parameters.AddWithValue("@from", From);
                cmd.Parameters.AddWithValue("@to", To);

                return Convert.ToDouble(cmd.ExecuteScalar());

            }
            catch (SqlException)
            {
                MessageBox.Show(@"There is a problem connecting to the database", @"Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            catch (InvalidCastException)
            {
                MessageBox.Show(@"There is no sales occured in this time-frame", @"Connection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return 0;
            }

            finally
            {
                con.Close();
            }
        }
    }
}

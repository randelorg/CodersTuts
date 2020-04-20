using System;
using System.Data.SqlClient;
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
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return -1;
            }

            catch (InvalidCastException ex)
            {
                return -2;
            }

            finally
            {
                con.Close();
            }
        }
    }
}

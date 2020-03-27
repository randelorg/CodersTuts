using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace DellRainInventorySystem.SQL
{
    public class Connect
    {
        private readonly SqlConnection connectionString = new SqlConnection(@"");
        public SqlConnection ConnectionString => connectionString;
        
        protected internal void Conn()
        {
            Console.WriteLine(@"Trying to connect");
            try
            {
                // Connect to SQL
                Console.Write(@"Connecting to SQL Server ... ");
                using (var connection = new SqlConnection())
                {
                    connection.Open();
                    Debug.WriteLine(@"Done, connected");
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine(@"Cannot connect to the database");
                MessageBox.Show(@"Cannot connect to the database", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Debug.WriteLine(e.ToString());
            }

            Debug.WriteLine(@"All done. Press any key to finish...");
        }
    }
    
    
}
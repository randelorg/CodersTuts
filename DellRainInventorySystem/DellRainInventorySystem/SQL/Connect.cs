using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace DellRainInventorySystem.SQL
{
    public class Connect
    {
        protected internal void Conn()
        {
            Console.WriteLine(@"Trying to connect");
            try
            {
                String connectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=RANDEL-PC";
                
                // Connect to SQL
                Console.Write(@"Connecting to SQL Server ... ");
                using (var connection = new SqlConnection(connectionString))
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
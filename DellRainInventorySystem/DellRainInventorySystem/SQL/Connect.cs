using System;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DellRainInventorySystem.SQL
{
    public class Connect
    {
        protected internal void Conn()
        {
            Console.WriteLine(@"Trying to connect");
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "RANDELLAPPY";   // update me
                builder.UserID = "randel";              // update me
                builder.Password = "";      // update me
                builder.InitialCatalog = "InventoryDB";

                // Connect to SQL
                Console.Write(@"Connecting to SQL Server ... ");
                using (var connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    Debug.WriteLine(@"Done, connected");
                }
            }
            catch (SqlException e)
            {
                Debug.WriteLine(@"Cannot connect to the database");
                Debug.WriteLine(e.ToString());
            }

            Debug.WriteLine(@"All done. Press any key to finish...");
        }
    }
    
    
}
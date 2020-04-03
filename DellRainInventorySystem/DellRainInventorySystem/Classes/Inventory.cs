using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using DellRainInventorySystem.Interfaces;

namespace DellRainInventorySystem.Classes
{
    public class Inventory : InventoryUtils, IInventory
    {
        //sql attr
        private SqlConnection con = new SqlConnection(
            "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=RANDEL-PC");
        private SqlCommand cmd;
        private SqlDataReader _reader;
        
        //identifies the user to the index window
        //serves the session 
        private static string sess_username;
        private static string sess_accType;
        public static string Firstname { get; set; }
        public static string Lastname { get; set; }
        
        public string SessUsername
        {
            get => sess_username;
            set => sess_username = value;
        }

        public string SessAccType
        {
            get => sess_accType;
            set => sess_accType = value;
        }

        public void Session(string username, string accType)
        {
            sess_username = username;
            sess_accType = accType;
        }

        public int AddAccount()
        {
            try
            {
                
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Inventory.Account (firstname, lastname, gender, contactNumber, username, password, accType)" +
                                  "VALUES (@fname, @lname, @gender, @number, @username, @password, @accType)";

                foreach (var staff in LtStaff)
                {
                    cmd.Parameters.AddWithValue("@fname", staff.Firstname);
                    cmd.Parameters.AddWithValue("@lname", staff.Lastname);
                    cmd.Parameters.AddWithValue("@gender", staff.Gender);
                    cmd.Parameters.AddWithValue("@number", staff.Contact);
                    cmd.Parameters.AddWithValue("@username", staff.Username);
                    cmd.Parameters.AddWithValue("@password", staff.Password);
                    cmd.Parameters.AddWithValue("accType", staff.AccType);
                }

                _reader = cmd.ExecuteReader();

                LtStaff.Clear();
                return 0;
            }

            catch (SqlException e)
            {
                return 1;
            }

            finally{con.Close();}
        }

        public void AddProduct()
        {
            throw new NotImplementedException();
        }

        public void AddSupplier()
        {
            throw new NotImplementedException();
        }

        public void AddLocation()
        {
            throw new NotImplementedException();
        }

    }
}
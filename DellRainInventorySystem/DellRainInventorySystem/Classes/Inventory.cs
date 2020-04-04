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

                if (LtuUsers.Count > 0)
                {
                    var user = LtuUsers.Last.Value; //get the last added value in the link-list
                    cmd.Parameters.AddWithValue("@fname", user.Firstname);
                    cmd.Parameters.AddWithValue("@lname", user.Lastname);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@number", user.Contact);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", user.Password);
                    cmd.Parameters.AddWithValue("accType", user.AccType);
                }

                _reader = cmd.ExecuteReader();
                _reader.Close();
                return 0;
            }

            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
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

        public int ChangePassword(string old, string newPass)
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT AccountId FROM Inventory.Account WHERE firstname = @fname";
                cmd.Parameters.AddWithValue("fname", Inventory.Firstname);
                _reader = cmd.ExecuteReader();

                if (_reader.Read())
                {
                    cmd.CommandText = "UPDATE Inventory.Account SET password = @newpword WHERE AccountId = @id";
                    cmd.Parameters.AddWithValue("@id", int.Parse(_reader["AccountId"].ToString()));
                    cmd.Parameters.AddWithValue("@newpword", newPass);

                    /*close the previous reader and execute the 
                    latest query which is the update query*/
                    _reader.Close();
                    cmd.ExecuteNonQuery();
                }

                return 0;
            }
            catch (SqlException)
            {
                return 1;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
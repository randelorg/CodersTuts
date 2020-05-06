using System;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using DellRainInventorySystem.Classes.Hashing;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.Interfaces;

namespace DellRainInventorySystem.Classes
{
    internal class NewAccount : Inventory, IAccount
    {
        private InventoryUtils inventoryUtils = new InventoryUtils();

        public string Login(string username, string password)
        {
            
            //sql query
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                //sql query
                cmd.CommandText = "SELECT * FROM Inventory.Account";

                _reader = cmd.ExecuteReader();

                while (_reader.Read()){
                    if (_reader.HasRows)
                    {
                        if (_reader["username"].ToString().Equals(username) && Hash.Decode(_reader["password"].ToString()).Equals(password))
                        {
                            inventoryUtils.Session(_reader["firstname"] + " " + _reader["lastname"],
                                _reader["accType"].ToString().ToUpper());

                            InventoryUtils.Firstname = _reader["firstname"].ToString();
                            InventoryUtils.Lastname = _reader["Lastname"].ToString();
                            return "success";
                        }
                    }
                }

                return "failed";
            }

            catch (SqlException a)
            {
                Debug.WriteLine(a.ToString());
                MessageBox.Show(@"Cannot connect to the database", @"Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "error";
            }

            finally
            {
                con.Close();
            }
        }

        public int AddAccount()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText = "INSERT INTO Inventory.Account (firstname, lastname, gender, contactNumber, username, password, accType) VALUES (@fname, @lname, @gender, @number, @username, @password, @accType)";

                if (LtuUsers.Count > 0)
                {
                    var user = LtuUsers.Last.Value; //get the last added value in the link-list
                    cmd.Parameters.AddWithValue("@fname", user.Firstname);
                    cmd.Parameters.AddWithValue("@lname", user.Lastname);
                    cmd.Parameters.AddWithValue("@gender", user.Gender);
                    cmd.Parameters.AddWithValue("@number", user.Contact);
                    cmd.Parameters.AddWithValue("@username", user.Username);
                    cmd.Parameters.AddWithValue("@password", Hash.Encode(user.Password));
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

            finally
            {
                con.Close();
            }
        }

        public int ChangePassword(string old, string newPass)
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT AccountId FROM Inventory.Account WHERE firstname = @fname";
                cmd.Parameters.AddWithValue("fname", Firstname);
                _reader = cmd.ExecuteReader();

                if (_reader.Read())
                {
                    cmd.CommandText = "UPDATE Inventory.Account SET password = @newpword WHERE AccountId = @id";
                    cmd.Parameters.AddWithValue("@id", Convert.ToInt32(_reader["AccountId"]));
                    cmd.Parameters.AddWithValue("@newpword", Hash.Encode(newPass));

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

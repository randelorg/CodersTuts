using DellRainInventorySystem.Interfaces;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DellRainInventorySystem.Classes
{
    public class Inventory : InventoryUtils, IInventory
    {
        //sql attr
        private readonly SqlConnection con = new SqlConnection(
            "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=RANDEL-PC");

        private SqlCommand cmd;
        private SqlDataReader _reader;
        private int suppId = 0; //for supplier ID
        private int LocationId = 0; //for Location ID

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

        public int AddLocation()
        {
            try
            {
                var product = LtProducts.Last.Value; //last product added in the linked list

                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                //location table
                cmd.CommandText = "SELECT * FROM Inventory.Location WHERE name = @locName";
                cmd.Parameters.AddWithValue("@locName", product.Location);
                _reader = cmd.ExecuteReader();

                if (_reader.Read()) //if location is already existing
                {
                    LocationId = int.Parse(_reader["locaId"].ToString());
                    _reader.Close();//close first query
                }
                else //if location is new add to the DB
                {
                    _reader.Close();

                    //adding row to the Location table
                    cmd.CommandText = "INSERT INTO Inventory.Location (name) " +
                                      "VALUES (@newlocation)";
                    cmd.Parameters.AddWithValue("@newlocation", product.Location);
                    _reader = cmd.ExecuteReader();
                    _reader.Close();//close second query

                    //purpose of getting the primary key of the new added location
                    cmd.CommandText = "SELECT * FROM Inventory.Location WHERE name = @locationName";
                    cmd.Parameters.AddWithValue("@locationName", product.Location);
                    _reader = cmd.ExecuteReader();

                    //store the supplier id to the suppId var
                    if (_reader.Read())
                        LocationId = int.Parse(_reader["locaId"].ToString());

                    _reader.Close();//close third query
                }

                _reader.Close();//close third query
                return 0; //if adding is succesful

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return 1; //if there are db errors
            }
            finally { con.Close(); }
        }

        public int AddSupplier()
        {
            try
            {
                var product = LtProducts.Last.Value; //last product added in the linked list

                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                //supplier table
                cmd.CommandText = "SELECT * FROM Inventory.Supplier WHERE suppName = @name";
                cmd.Parameters.AddWithValue("@name", product.CompanyName);
                _reader = cmd.ExecuteReader();

                Console.WriteLine(product.CompanyName);

                if (_reader.Read()) //if the supplier is already existing
                {
                    //store the supplier id to the suppId var
                    suppId = int.Parse(_reader["suppId"].ToString());
                }
                else //if the supplier is new add to the DB
                {
                    _reader.Close();

                    //adding row to the Supplier table
                    cmd.CommandText = "INSERT INTO Inventory.Supplier (suppName, ContactNumber) " +
                                      "VALUES (@newSuppName,@newSuppNum)";
                    cmd.Parameters.AddWithValue("@newSuppName", product.CompanyName);
                    cmd.Parameters.AddWithValue("@newSuppNum", product.Contact);
                    _reader = cmd.ExecuteReader();
                    _reader.Close();//close forth query

                    //purpose of getting the primary key of the new added supplier
                    cmd.CommandText = "SELECT * FROM Inventory.Supplier WHERE suppName = @Suppliername";
                    cmd.Parameters.AddWithValue("@Suppliername", product.CompanyName);
                    _reader = cmd.ExecuteReader();

                    //store the supplier id to the suppId var
                    if (_reader.Read())
                        suppId = int.Parse(_reader["suppId"].ToString());

                    _reader.Close();//close third query
                }

                _reader.Close();//close third query
                return 0; //if adding the supplier is successful

            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return 2;  //if there are db errors
            }
            finally { con.Close(); }
        }

        public int AddProduct()
        {
            ErrorMessage(AddLocation());
            ErrorMessage(AddSupplier());
            Console.WriteLine(@"Location id {0}", LocationId);
            Console.WriteLine(@"Supplier id {0}", suppId);

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText =
                    "INSERT INTO Inventory.Product (Supplier, prodName, prodType, prodQty, prodPrice, Location, prodShelfLife)" +
                    "VALUES (@supplier, @name, @type, @qty, @price, @location, @life)";

                if (LtProducts.Count > 0)
                {
                    var product = LtProducts.Last.Value; //last product added in the linked list
                    cmd.Parameters.AddWithValue("@supplier", suppId);
                    cmd.Parameters.AddWithValue("@name", product.ProdName);
                    cmd.Parameters.AddWithValue("@type", product.ProdType);
                    cmd.Parameters.AddWithValue("@qty", product.Qty);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@location", LocationId);
                    cmd.Parameters.AddWithValue("@life", product.Shelflife);
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

            finally { con.Close(); }
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

            finally { con.Close(); }
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

        private void ErrorMessage(int i)
        {
            // 1 for adding location and 2 for adding supplier error
            switch (i)
            {
                case 1:
                    MessageBox.Show(@"Could not save product location", @"DB Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    break;
                case 2:
                    MessageBox.Show(@"Could not save product supplier", @"DB Error", MessageBoxButtons.OK
                        , MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
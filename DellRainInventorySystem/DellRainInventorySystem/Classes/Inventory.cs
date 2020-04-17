using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;
using DellRainInventorySystem.Interfaces;

namespace DellRainInventorySystem.Classes
{
    public class Inventory : InventoryUtils, IInventory, IAccount
    {
        //connection string
        private readonly SqlConnection con = new SqlConnection(Connect.MainConn);

        private SqlDataReader _reader;

        private SqlCommand cmd;

        public int AddAccount()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText =
                    "INSERT INTO Inventory.Account (firstname, lastname, gender, contactNumber, username, password, accType)" +
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
                    Console.WriteLine(@"LOCATION UPDATE {0}", LocationId);
                    _reader.Close(); //close first query
                }
                else //if location is new add to the DB
                {
                    _reader.Close();

                    //adding row to the Location table
                    cmd.CommandText = "INSERT INTO Inventory.Location (name) " +
                                      "VALUES (@newlocation)";
                    cmd.Parameters.AddWithValue("@newlocation", product.Location);
                    _reader = cmd.ExecuteReader();
                    _reader.Close(); //close second query

                    //purpose of getting the primary key of the new added location
                    cmd.CommandText = "SELECT * FROM Inventory.Location WHERE name = @locationName";
                    cmd.Parameters.AddWithValue("@locationName", product.Location);
                    _reader = cmd.ExecuteReader();

                    //store the supplier id to the suppId var
                    if (_reader.Read())
                        LocationId = int.Parse(_reader["locaId"].ToString());

                    _reader.Close(); //close third query
                }

                _reader.Close(); //close third query
                return 0; //if adding is successful
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return 1; //if there are db errors
            }
            finally
            {
                con.Close();
            }
        }

        public int PrepareProductToUpdate()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT [product].prodImage ,[product].prodName ,[product].prodPrice, [product].prodShelfLife,[location].name,[supplier].suppName, [supplier].contactNumber FROM Inventory.Product AS product INNER JOIN Inventory.Supplier AS supplier ON [product].Supplier = [supplier].suppId INNER JOIN Inventory.Location AS location  ON [location].locaId = [product].Location WHERE [product].productId = @PRODUCT_ID";

                cmd.Parameters.AddWithValue("@PRODUCT_ID", UpdateProdId);
                _reader = cmd.ExecuteReader();

                if (_reader.Read())
                    LtProducts.AddLast(new Product(Base64ToImage(_reader["prodImage"].ToString()),
                        _reader["prodName"].ToString(),
                        double.Parse(_reader["prodPrice"].ToString()),
                        _reader["name"].ToString(), _reader["prodShelfLife"].ToString(),
                        _reader["suppName"].ToString(), _reader["contactNumber"].ToString()));

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

        public int UpdateSelectedProduct()
        {
            var product = LtProducts.Last.Value;

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "UPDATE Inventory.Product SET prodImage = @image, prodName = @name, prodPrice = @price, prodQty += @addQty, prodShelfLife = @life, Supplier = @supplierId, Location = @locationId WHERE productId = @prodId";

                if (LtProducts.Count > 0)
                {
                    cmd.Parameters.AddWithValue("@image", ImageToBase64(product.ProdImage, ImageFormat.Png));
                    cmd.Parameters.AddWithValue("@name", product.ProdName);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@addQty", product.Qty);
                    cmd.Parameters.AddWithValue("@life", product.Shelflife);
                    cmd.Parameters.AddWithValue("@supplierId", SuppId);
                    cmd.Parameters.AddWithValue("@locationId", LocationId);
                    cmd.Parameters.AddWithValue("@prodId", UpdateProdId);
                }

                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Inventory.Supplier SET contactNumber = @number WHERE suppId = @id";

                cmd.Parameters.AddWithValue("@id", SuppId);
                cmd.Parameters.AddWithValue("@number", product.Contact);

                cmd.ExecuteNonQuery();

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

        public int SoldProduct()
        {
            var price = 0.00;

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT prodPrice FROM Inventory.Product WHERE productId = @firstId";
                cmd.Parameters.AddWithValue("@firstId", UpdateProdId);
                _reader = cmd.ExecuteReader();

                if (_reader.Read())
                    price = double.Parse(_reader["prodPrice"].ToString());
                
                _reader.Close();

                Console.WriteLine(@"Product price {0}", price);

                cmd.CommandText = "INSERT INTO Inventory.Sales (product, qtySold, date, sales) VALUES(@product_FK, @sold, @date, @sale)";
                cmd.Parameters.AddWithValue("@product_FK", UpdateProdId);
                cmd.Parameters.AddWithValue("@sold", SoldNumber);
                cmd.Parameters.AddWithValue("@date", DateTime.UtcNow.ToShortDateString());
                cmd.Parameters.AddWithValue("@sale", SoldNumber * price);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Inventory.Product SET prodSold += @total_sold WHERE productId = @product_PK";
                cmd.Parameters.AddWithValue("@product_PK", UpdateProdId);
                cmd.Parameters.AddWithValue("@total_sold", SoldNumber);
                cmd.ExecuteNonQuery();

                cmd.CommandText = "UPDATE Inventory.Product SET prodQty -= @past_sold WHERE productId = @product_PK_PAST";
                cmd.Parameters.AddWithValue("@product_PK_PAST", UpdateProdId);
                cmd.Parameters.AddWithValue("@past_sold", SoldNumber);
                cmd.ExecuteNonQuery();

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

        public int ComputeDaySale()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select SUM(sales) from Inventory.Sales where date = @datetoday";
                cmd.Parameters.AddWithValue("@datetoday", DateTime.UtcNow.ToShortDateString());

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

            finally
            {
                con.Close();
            }
        }

        public void LoadForSoldWindow()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                //location table
                cmd.CommandText = "SELECT * FROM Inventory.Product WHERE productId = @Id";
                cmd.Parameters.AddWithValue("@Id", UpdateProdId);
                _reader = cmd.ExecuteReader();

                if (_reader.Read())
                {
                    //add image to the last node 
                    LtProducts.AddLast(new Product(Base64ToImage(_reader["prodImage"].ToString()),
                        _reader["prodName"].ToString(), double.Parse(_reader["prodPrice"].ToString())));
                }

                _reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally{con.Close();}
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
                    SuppId = int.Parse(_reader["suppId"].ToString());
                    Console.WriteLine(@"SUPPLIER UPDATE {0}", SuppId);
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
                    _reader.Close(); //close forth query

                    //purpose of getting the primary key of the new added supplier
                    cmd.CommandText = "SELECT * FROM Inventory.Supplier WHERE suppName = @Suppliername";
                    cmd.Parameters.AddWithValue("@Suppliername", product.CompanyName);
                    _reader = cmd.ExecuteReader();

                    //store the supplier id to the suppId var
                    if (_reader.Read())
                        SuppId = int.Parse(_reader["suppId"].ToString());

                    _reader.Close(); //close third query
                }

                _reader.Close(); //close third query
                return 0; //if adding the supplier is successful
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return 2; //if there are db errors
            }
            finally
            {
                con.Close();
            }
        }

        public int AddProduct()
        {
            ErrorMessage(AddLocation());
            ErrorMessage(AddSupplier());
            Console.WriteLine(@"Location id {0}", LocationId);
            Console.WriteLine(@"Supplier id {0}", SuppId);

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;

                cmd.CommandText =
                    "INSERT INTO Inventory.Product (Supplier, prodName, prodType, prodQty, prodPrice, Location, prodShelfLife, prodImage) VALUES (@supplier, @name, @type, @qty, @price, @location, @life, @image)";

                if (LtProducts.Count > 0)
                {
                    var product = LtProducts.Last.Value; //last product added in the linked list
                    cmd.Parameters.AddWithValue("@supplier", SuppId);
                    cmd.Parameters.AddWithValue("@name", product.ProdName);
                    cmd.Parameters.AddWithValue("@type", product.ProdType);
                    cmd.Parameters.AddWithValue("@qty", product.Qty);
                    cmd.Parameters.AddWithValue("@price", product.Price);
                    cmd.Parameters.AddWithValue("@location", LocationId);
                    cmd.Parameters.AddWithValue("@life", product.Shelflife);
                    cmd.Parameters.AddWithValue("@image", ImageToBase64(product.ProdImage, ImageFormat.Png));
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

        public bool GetExistingLocation()
        {
            if (ExistingLocation.Count > 0)
                ExistingLocation.Clear();

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT name FROM Inventory.Location";
                _reader = cmd.ExecuteReader();

                while (_reader.Read())
                    if (_reader.HasRows)
                        ExistingLocation.AddFirst(_reader["name"].ToString());

                Console.WriteLine(@"Row count {0}", ExistingLocation.Count);
                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return true;
            }

            finally
            {
                con.Close();
            }
        }

        public bool GetExistingSupplier()
        {
            if (ExistingSuppliers.Count > 0)
                ExistingSuppliers.Clear();

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT suppName FROM Inventory.Supplier";
                _reader = cmd.ExecuteReader();

                while (_reader.Read())
                    if (_reader.HasRows)
                        ExistingSuppliers.AddFirst(_reader["suppName"].ToString());

                Console.WriteLine(@"Row count {0}", ExistingSuppliers.Count);
                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return true;
            }

            finally
            {
                con.Close();
            }
        }

        public bool DetermineTopSellingProducts()
        {
            if (TopSelling.Count > 0)
                TopSelling.Clear();

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT prodImage FROM Inventory.Product WHERE prodSold >= @TOP";
                cmd.Parameters.AddWithValue("@TOP", TopSellingCount);
                _reader = cmd.ExecuteReader();

                while (_reader.Read())
                {
                    if (string.IsNullOrEmpty(_reader["prodImage"].ToString())) continue;

                    if (_reader.HasRows) TopSelling.AddFirst(Base64ToImage(_reader["prodImage"].ToString()));
                }

                // Console.WriteLine(@"Top selling Row count {0}", TopSelling.Count);
                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return true;
            }

            finally
            {
                con.Close();
            }
        }

        public bool DetermineProductInThresholdLevel()
        {
            if (LowOnStock.Count > 0)
                LowOnStock.Clear();

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT prodImage FROM Inventory.Product WHERE prodQty <= @CRIT";
                cmd.Parameters.AddWithValue("@CRIT", CriticalLevel);
                _reader = cmd.ExecuteReader();


                while (_reader.Read())
                {
                    if (string.IsNullOrEmpty(_reader["prodImage"].ToString())) continue;

                    if (_reader.HasRows) LowOnStock.AddFirst(Base64ToImage(_reader["prodImage"].ToString()));
                }

                //Console.WriteLine(@"Threshold level Row count {0}", LowOnStock.Count);
                return false;
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return true;
            }

            finally
            {
                con.Close();
            }
        }

        public int CountGroceriesProductsQty()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT SUM(prodQty) FROM Inventory.Product WHERE prodType = @type";
                cmd.Parameters.AddWithValue("@type", Type2);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }

            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
            }

            finally
            {
                con.Close();
            }
        }

        public int CountApplianceProductsQty()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT SUM(prodQty) FROM Inventory.Product WHERE prodType = @type";
                cmd.Parameters.AddWithValue("@type", Type1);

                return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
                return -1;
            }

            catch(InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
                return 0;
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

        //convert image to byte the save to database
        private string ImageToBase64(Image image,
            ImageFormat format)
        {
            using (var ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, format);
                var imageBytes = ms.ToArray();

                // Convert byte[] to Base64 String
                var base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }

        //retrieve image from the database
        private Image Base64ToImage(string base64String)
        {
            Image image = null;
            try
            {
                // Convert Base64 String to byte[]
                var imageBytes = Convert.FromBase64String(base64String);
                var ms = new MemoryStream(imageBytes, 0,
                    imageBytes.Length);

                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                image = Image.FromStream(ms, true);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return image;
        }
    }
}
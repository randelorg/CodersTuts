using System;
using System.Data.SqlClient;
using System.Drawing.Imaging;
using DellRainInventorySystem.Classes.EntityClasses;
using DellRainInventorySystem.Interfaces;

namespace DellRainInventorySystem.Classes
{
    internal class UpdateAddProduct: Inventory, IUpdateAddProduct
    {
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

                cmd.CommandText = "INSERT INTO Inventory.Product (Supplier, prodName, prodType, prodQty, prodPrice, Location, prodShelfLife, prodImage) VALUES (@supplier, @name, @type, @qty, @price, @location, @life, @image)";

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

    }
}

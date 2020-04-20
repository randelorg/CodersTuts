using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;
using DellRainInventorySystem.Classes.EntityClasses;
using DellRainInventorySystem.Classes.Utility;
using DellRainInventorySystem.ConnectDB;
using DellRainInventorySystem.Interfaces;

namespace DellRainInventorySystem.Classes
{
    public class Inventory : InventoryUtils, IInventory
    {
        //connection string
        protected readonly SqlConnection con = new SqlConnection(Connect.MainConn);

        protected SqlDataReader _reader;

        protected SqlCommand cmd;

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

                if (_reader.Read()) { 
                    price = double.Parse(_reader["prodPrice"].ToString());
                }

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

        public double ComputeDaySale()
        {
            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "select SUM(sales) from Inventory.Sales where date = @datetoday";
                cmd.Parameters.AddWithValue("@datetoday", DateTime.UtcNow.ToShortDateString());

                return Convert.ToDouble(cmd.ExecuteScalar());
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

        public double ComputeWeekSale()
        {
            //will determine the monday and sunday date of the current week
            WeekDates();

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT SUM(sales) FROM  Inventory.Sales WHERE date BETWEEN @thismonday AND @thissunday";
                cmd.Parameters.AddWithValue("@thismonday", MondayDate);
                cmd.Parameters.AddWithValue("@thissunday", SundayDate);

                return Convert.ToDouble(cmd.ExecuteScalar());
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
                    //add image to the last node 
                    LtProducts.AddLast(new Product(Base64ToImage(_reader["prodImage"].ToString()),
                        _reader["prodName"].ToString(), Convert.ToDouble(_reader["prodPrice"].ToString()),
                        Convert.ToInt32(_reader["prodQty"].ToString())));

                _reader.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
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

        public bool TopSellingProductsToday()
        {
            
            if (TopSelling.Count > 0)
                TopSelling.Clear();

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT DISTINCT [s].product,  [product].prodImage FROM Inventory.Product AS product INNER JOIN Inventory.Sales AS s ON [s].product = [product].productId WHERE qtySold > (SELECT AVG(qtySold) FROM Inventory.Sales WHERE date = @dateToday)";
                cmd.Parameters.AddWithValue("@dateToday", DateTime.UtcNow.ToShortDateString());
                _reader = cmd.ExecuteReader();

                while (_reader.Read())
                {
                    if (string.IsNullOrEmpty(_reader["prodImage"].ToString())) continue;

                    if (_reader.HasRows) TopSelling.AddFirst(Base64ToImage(_reader["prodImage"].ToString()));
                }

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

        public bool TopSellingProductsThisWeek()
        {
            //will determine the monday and sunday date of the current week
            WeekDates();

            if (TopSelling.Count > 0)
                TopSelling.Clear();

            try
            {
                cmd = new SqlCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT DISTINCT [s].product, [product].prodImage FROM Inventory.Product AS product INNER JOIN Inventory.Sales AS s ON [s].product = [product].productId WHERE qtySold > (SELECT AVG(qtySold) FROM Inventory.Sales WHERE date BETWEEN @thismonday AND @thissunday)";
                cmd.Parameters.AddWithValue("@thismonday", MondayDate);
                cmd.Parameters.AddWithValue("@thissunday", SundayDate);
                
                _reader = cmd.ExecuteReader();

                while (_reader.Read())
                {
                    if (string.IsNullOrEmpty(_reader["prodImage"].ToString())) continue;

                    if (_reader.HasRows)
                    {
                        TopSelling.AddFirst(Base64ToImage(_reader["prodImage"].ToString()));
                    }
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

        protected void ErrorMessage(int i)
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
        protected string ImageToBase64(Image image,
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
        protected Image Base64ToImage(string base64String)
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

        private void WeekDates()
        {
            DayOfWeek Day = DateTime.Now.DayOfWeek;

            //Week Start Day
            int Days = Day - DayOfWeek.Monday;

            //this is the date of monday of the current week
            DateTime weekStartDate = DateTime.Now.AddDays(-Days);

            //this is the date of sunday of the current week
            DateTime weekEndDate6 = weekStartDate.AddDays(6);

            MondayDate = weekStartDate.ToShortDateString();
            SundayDate = weekEndDate6.ToShortDateString();
        }
    }
}
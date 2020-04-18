using System.Collections.Generic;
using System.Drawing;
using DellRainInventorySystem.Classes.EntityClasses;

namespace DellRainInventorySystem.Classes.Utility
{
    public class InventoryUtils
    {
        //constant critical product threshold level
        protected const int CriticalLevel = 5;

        //Primary key of product soon to be updated
        protected internal static int UpdateProdId = 0;

        //for how many aty had been sold of the product in a particular push / click of the button
        protected internal static int SoldNumber = 0;

        protected const string Type1 = "Appliance";
        protected const string Type2 = "Grocery";

        protected internal static LinkedList<User> LtuUsers = new LinkedList<User>();
        protected internal static LinkedList<Product> LtProducts = new LinkedList<Product>();

        protected internal static LinkedList<Image> TopSelling = new LinkedList<Image>();
        protected internal static LinkedList<Image> LowOnStock = new LinkedList<Image>();

        protected internal static LinkedList<string> ExistingSuppliers = new LinkedList<string>();
        protected internal static LinkedList<string> ExistingLocation = new LinkedList<string>();

        //identifies the user to the index window
        //serves the session 
        private static string sess_username;
        private static string sess_accType;

        //for referencing the supplier id and location id
        //in the DB table
        protected int SuppId { get; set; }
        protected int LocationId { get; set; }
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

        protected static string MondayDate { get; set; }
        protected static string SundayDate { get; set; }
    }
}
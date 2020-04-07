using System.Collections;
using System.Collections.Generic;
using System.Drawing;

namespace DellRainInventorySystem.Classes
{
    public class InventoryUtils
    {
        protected internal static LinkedList<User> LtuUsers = new LinkedList<User>();
        protected internal static LinkedList<Product> LtProducts = new LinkedList<Product>();

        protected internal static LinkedList<Image> TopSelling = new LinkedList<Image>();
        protected internal static LinkedList<Image> LowOnStock = new LinkedList<Image>();

        protected internal static LinkedList<string> ExistingSuppliers = new LinkedList<string>();
        protected internal static LinkedList<string> ExistingLocation = new LinkedList<string>();

        //constant critical product threshold level
        protected const int CriticalLevel = 5;

        //constant top selling products count
        protected const int TopSellingCount = 10;

        //for referencing the supplier id and location id
        //in the DB table
        protected int SuppId { get; set; } = 0;
        protected int LocationId { get; set; } = 0;

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
    }
}
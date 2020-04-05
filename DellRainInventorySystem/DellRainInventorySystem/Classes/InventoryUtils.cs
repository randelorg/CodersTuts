using System.Collections;
using System.Collections.Generic;

namespace DellRainInventorySystem.Classes
{
    public class InventoryUtils
    {
        protected internal static LinkedList<User> LtuUsers = new LinkedList<User>();
        protected internal static LinkedList<Product> LtProducts = new LinkedList<Product>();

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
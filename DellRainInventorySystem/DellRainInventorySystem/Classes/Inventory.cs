using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;

namespace DellRainInventorySystem.Classes
{
    public class Inventory : InventoryUtils
    {
        //identifies the user to the index window
        //serves the session 
        private static string sess_username;
        private static string sess_accType;
        
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
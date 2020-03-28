using System;
using System.Data.SqlClient;
using System.Diagnostics;
using DellRainInventorySystem.Interfaces;

namespace DellRainInventorySystem.Classes
{
    public class Inventory : InventoryUtils, IInventory
    {
        //sql attr
        private SqlConnection con = new SqlConnection(
            "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=InventoryDB;Data Source=RANDELLAPPY");
        private SqlCommand cmd;
        
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

        public void AddProduct()
        {
            throw new NotImplementedException();
        }

        public void AddAccount()
        {
            
        }

        public void AddSupplier()
        {
            throw new NotImplementedException();
        }

        public void AddLocation()
        {
            throw new NotImplementedException();
        }
    }
}
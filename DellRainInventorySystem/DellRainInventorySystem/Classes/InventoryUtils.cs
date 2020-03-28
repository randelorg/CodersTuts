using System.Collections;
using System.Collections.Generic;

namespace DellRainInventorySystem.Classes
{
    public class InventoryUtils
    {
        protected internal static LinkedList<Admin> LtAdmin = new LinkedList<Admin>();
        protected internal static LinkedList<Staff> LtStaff = new LinkedList<Staff>();
        protected internal static LinkedList<Product> LtProducts = new LinkedList<Product>();
        protected internal static LinkedList<Supplier> LtSupplier = new LinkedList<Supplier>();
        
        protected static ArrayList TextCredentials = new ArrayList();
    }
}
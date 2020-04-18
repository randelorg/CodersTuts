using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DellRainInventorySystem.Interfaces
{
    interface IUpdateAddProduct
    {
        /*This method will add a product in the Inventory.Product
        supplying all the columns except he prodSold column*/
        int AddProduct();

        /*This method will add product supplier or find the supplier
        if it is existing in the Inventory.Supplier db*/
        int AddSupplier();

        /*This method will add product location or find the location
        if it is existing in the Inventory.Supplier db*/
        int AddLocation();

        /*This method will prepare the selected product details
         for extraction in the database. 
         This will help to display the product details in the Update Window 
         and Sold Window*/
        int PrepareProductToUpdate();

        /*This method will update the selected product
         int the Update Window*/
        int UpdateSelectedProduct();
    }
}

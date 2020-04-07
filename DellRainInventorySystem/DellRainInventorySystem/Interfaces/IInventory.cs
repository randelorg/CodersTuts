using System.Drawing;
using System.Runtime.CompilerServices;

namespace DellRainInventorySystem.Interfaces
{
    public interface IInventory
    {
        int AddProduct();
        int AddSupplier();
        int AddLocation();
        int AddAccount();
        int ChangePassword(string old, string newPass);
        int FindExistingLocation();
        int FindExistingSupplier();
        int DetermineProductInThresholdLevel();
    }
}
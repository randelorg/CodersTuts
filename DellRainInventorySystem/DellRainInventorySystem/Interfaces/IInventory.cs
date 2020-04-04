using System.Runtime.CompilerServices;

namespace DellRainInventorySystem.Interfaces
{
    public interface IInventory
    {
        void AddProduct();
        int AddAccount();
        void AddSupplier();
        void AddLocation();
        int ChangePassword();
    }
}
using System.Runtime.CompilerServices;

namespace DellRainInventorySystem.Interfaces
{
    public interface IInventory
    {
        int AddProduct();
        int AddAccount();
        int ChangePassword(string old, string newPass);
    }
}
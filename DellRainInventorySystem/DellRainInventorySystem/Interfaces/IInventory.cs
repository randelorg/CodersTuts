namespace DellRainInventorySystem.Interfaces
{
    public interface IInventory
    {
        int AddProduct();
        int AddSupplier();
        int AddLocation();
        int PrepareProductToUpdate();
        int UpdateSelectedProduct();
        int SoldProduct();
        void LoadForSoldWindow();
        bool GetExistingLocation();
        bool GetExistingSupplier();
        bool DetermineTopSellingProducts();
        bool DetermineProductInThresholdLevel();
        int CountGroceriesProductsQty();
        int CountApplianceProductsQty();
    }
}
namespace DellRainInventorySystem.Interfaces
{
    public interface IInventory
    {
        int SoldProduct();
        int ComputeDaySale();
        int ComputeWeekSale();
        void LoadForSoldWindow();
        bool GetExistingLocation();
        bool GetExistingSupplier();
        bool TopSellingProductsToday();
        bool TopSellingProductsThisWeek();
        bool DetermineProductInThresholdLevel();
        int CountGroceriesProductsQty();
        int CountApplianceProductsQty();
    }
}
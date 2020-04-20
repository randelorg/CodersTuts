namespace DellRainInventorySystem.Interfaces
{
    public interface IInventory
    {
        int SoldProduct();
        double ComputeDaySale();
        double ComputeWeekSale();
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
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
        void TopSellingProductsToday();
        void TopSellingProductsThisWeek();
        bool DetermineProductInThresholdLevel();
        int CountGroceriesProductsQty();
        int CountApplianceProductsQty();
    }
}
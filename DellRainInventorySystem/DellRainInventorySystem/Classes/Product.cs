namespace DellRainInventorySystem.Classes
{
    public class Product
    {
        private string _prodName;
        private string _prodType;
        private int _qty;
        private int _sold;
        private float _price;
        
        public Product(string prodName, string prodType, int qty, int sold, float price)
        {
            _prodName = prodName;
            _prodType = prodType;
            _qty = qty;
            _sold = sold;
            this._price = price;
        }

        public string ProdName { get; set; }
        public string ProdType { get; set; }
        public int Qty { get; set; }
        public int Sold { get; set; }
        public float Price { get; set; }
    }
}
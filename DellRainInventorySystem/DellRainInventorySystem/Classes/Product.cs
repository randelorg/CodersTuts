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
        
        public string ProdName
        {
            get => _prodName;
            set => _prodName = value;
        }

        public string ProdType
        {
            get => _prodType;
            set => _prodType = value;
        }

        public int Qty
        {
            get => _qty;
            set => _qty = value;
        }

        public int Sold
        {
            get => _sold;
            set => _sold = value;
        }

        public float Price
        {
            get => _price;
            set => _price = value;
        }
    }
}
namespace DellRainInventorySystem.Classes
{
    public class Product : Supplier
    {
        private string _prodName;
        private string _prodType;
        private string _prodLocation;
        private string _shelfLife;
        private int _qty;
        private int _sold;
        private float _price;
        
        //empty 
        public Product() { }

        //for creation
        public Product(string prodName, string prodType, int qty, float price, string prodLocation, string life,
            string suppName, string suppContact) : base(suppName, suppContact)
        {
            _prodName = prodName;
            _prodType = prodType;
            _qty = qty;
            this._price = price;
            _prodLocation = prodLocation;
            _shelfLife = life;
        }

        //for updating
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

        public string Location
        {
            get => _prodLocation;
            set => _prodLocation = value;
        }
    }
}
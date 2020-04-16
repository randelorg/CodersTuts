using System.Drawing;

namespace DellRainInventorySystem.Classes
{
    public class Product : Supplier
    {
        //empty 
        public Product()
        {
        }

        //for creation
        public Product(string prodName, string prodType, int qty, float price, string prodLocation, string life,
            string suppName, string suppContact, Image image) : base(suppName, suppContact)
        {
            ProdName = prodName;
            ProdType = prodType;
            Qty = qty;
            Price = price;
            Location = prodLocation;
            Shelflife = life;
            ProdImage = image;
        }

        //for updating product except the qty
        public Product(Image image, string prodName, float price,
            string location, string life, string suppName, string suppContact) : base(suppName, suppContact)
        {
            ProdImage = image;
            ProdName = prodName;
            Price = price;
            Location = location;
            Shelflife = life;
        }

        //for updating the product
        public Product(Image image, string prodName, int qty, float price,
            string location, string life, string suppName, string suppContact) : base(suppName, suppContact)
        {
            ProdImage = image;
            ProdName = prodName;
            Qty = qty;
            Price = price;
            Location = location;
            Shelflife = life;
        }

        //for updating the product and adding qty to the product qt
        public Product(Image image, string prodName, int qty, float price, string life, string suppContact) : base(suppContact)
        {
            ProdImage = image;
            ProdName = prodName;
            Qty = qty;
            Price = price;
            Shelflife = life;
        }

        //image only fod sold product window
        public Product(Image image)
        {
            ProdImage = image;
        }

        public string ProdName { get; set; }

        public string ProdType { get; set; }

        public int Qty { get; set; }

        public int Sold { get; set; }

        public float Price { get; set; }

        public string Location { get; set; }

        public string Shelflife { get; set; }

        public Image ProdImage { get; set; }
    }
}
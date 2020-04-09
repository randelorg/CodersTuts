namespace DellRainInventorySystem.Classes
{
    public class Supplier
    {
        protected Supplier()
        {
        }

        protected Supplier(string companyName, string contact)
        {
            CompanyName = companyName;
            Contact = contact;
        }

        public string CompanyName { get; set; }

        public string Contact { get; set; }
    }
}
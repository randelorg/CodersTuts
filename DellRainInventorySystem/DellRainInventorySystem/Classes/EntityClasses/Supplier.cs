namespace DellRainInventorySystem.Classes.EntityClasses
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

        protected Supplier(string suppContact)
        {
            Contact = suppContact;
        }

        public string CompanyName { get; set; }

        public string Contact { get; set; }
    }
}
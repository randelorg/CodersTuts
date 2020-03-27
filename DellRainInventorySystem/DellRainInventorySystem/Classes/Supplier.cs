namespace DellRainInventorySystem.Classes
{
    public class Supplier
    {
        private string _companyName;
        private string _contact;
        
        protected Supplier(){}
        
        public Supplier(string companyName, string contact)
        {
            _companyName = companyName;
            _contact = contact;
        }

        public string CompanyName { get; set; }
        public string Contact { get; set; }
    }
}
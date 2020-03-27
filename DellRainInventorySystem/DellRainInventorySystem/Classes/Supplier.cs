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
        
        public string CompanyName
        {
            get => _companyName;
            set => _companyName = value;
        }

        public string Contact
        {
            get => _contact;
            set => _contact = value;
        }

    }
}
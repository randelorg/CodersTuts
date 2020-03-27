namespace DellRainInventorySystem.Classes
{
    public class Admin : Name
    {
        private string _username;
        private string _contact;
        private string _password;
        private string _accType;
        
        protected Admin(){}
        
        protected Admin(string username, string contact, string password, string accType)
        {
            _username = username;
            _contact = contact;
            _password = password;
            _accType = accType;
        }

        protected Admin(string firstname, string lastname, string username, string contact, string password, string accType) : base(firstname, lastname)
        {
            _username = username;
            _contact = contact;
            _password = password;
            _accType = accType;
        }
        
        public string Username
        {
            get => _username;
            set => _username = value;
        }

        public string Contact
        {
            get => _contact;
            set => _contact = value;
        }

        public string Password
        {
            get => _password;
            set => _password = value;
        }

        public string AccType
        {
            get => _accType;
            set => _accType = value;
        }

    }
}
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

        public string Username { get; set; }
        public string Contact { get; set; }
        public string Password { get; set; }
        public string AccType { get; set; }
        
    }
}
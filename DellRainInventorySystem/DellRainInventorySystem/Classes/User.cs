namespace DellRainInventorySystem.Classes
{
    public class User : Person
    {
        protected User()
        {
        }

        public User(string username, string contact, string password, string accType)
        {
            Username = username;
            Contact = contact;
            Password = password;
            AccType = accType;
        }

        public User(string firstname, string lastname, string gender, string username, string contact, string password,
            string accType) : base(firstname, lastname, gender)
        {
            Username = username;
            Contact = contact;
            Password = password;
            AccType = accType;
        }

        public string Username { get; set; }

        public string Contact { get; set; }

        public string Password { get; set; }

        public string AccType { get; set; }
    }
}
namespace DellRainInventorySystem.Classes
{
    public class Name
    {
        private string _firstname;
        private string _lastname;

        protected Name(){}

        protected Name(string firstname, string lastname)
        {
            this._firstname = firstname;
            this._lastname = lastname;
        }
        
        public string Firstname
        {
            get => _firstname;
            set => _firstname = value;
        }

        public string Lastname
        {
            get => _lastname;
            set => _lastname = value;
        }
        
    }
}
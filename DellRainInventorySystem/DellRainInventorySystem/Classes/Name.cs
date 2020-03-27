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

        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}
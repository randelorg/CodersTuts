namespace DellRainInventorySystem.Classes
{
    public class Person
    {
        private string _firstname;
        private string _lastname;
        private string _gender;

        protected Person(){}

        protected Person(string firstname, string lastname, string gender)
        {
            this._firstname = firstname;
            this._lastname = lastname;
            this._gender = gender;
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

        public string Gender
        {
            get => _gender;
            set => _gender = value;
        }
        
    }
}
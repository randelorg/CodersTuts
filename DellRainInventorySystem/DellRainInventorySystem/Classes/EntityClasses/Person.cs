namespace DellRainInventorySystem.Classes.EntityClasses
{
    public class Person
    {
        protected Person()
        {
        }

        protected Person(string firstname, string lastname, string gender)
        {
            Firstname = firstname;
            Lastname = lastname;
            Gender = gender;
        }

        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public string Gender { get; set; }
    }
}
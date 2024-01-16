namespace CreatingClasses
{
    public class Person
    {
        private static int idCount = 1;

        private int personId;
        private string firstName;
        private string lastName;
        private string favoriteColor;
        private int age;
        private bool isWorking;
        private Relation relationship;

        // Constructor, sets variables, increases ID count
        public Person(string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.personId = idCount;
            this.firstName = firstName;
            this.lastName = lastName;
            this.favoriteColor = favoriteColor;
            this.age = age;
            this.isWorking = isWorking;

            idCount++;
        }

        // Adds a relationship between this object and another person
        public void AddRelationship(Person person, string type)
        {
            this.relationship = new Relation(this, person, type);
        }

        // Prints out some of the persons personal info
        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name = {this.firstName} {this.lastName}");
        }

        // Changes the favoriteColour variable
        public void ChangeFavoriteColour(string newColor)
        {
            this.favoriteColor = newColor;
        }

        // Gets the persons age in 10 years
        public int GetAgeInTenYears()
        {
            return this.age + 10;
        }

        // Gets the relationship the person has.
        public Relation GetRelationship()
        {
            return this.relationship;
        }

        // Gets the ID of the person
        public int GetPersonId()
        {
            return this.personId;
        }

        // Gets the favorite colour of the person
        public String GetFavoriteColour()
        {
            return this.favoriteColor;
        }

        // Gets the first name of the person
        public String GetFirstName()
        {
            return this.firstName;
        }

        // Gets the last name of the person
        public String GetLastName()
        {
            return this.lastName;
        }

        // Gets the age of the person
        public int GetAge()
        {
            return this.age;
        }

        // Displays each point of data from this object
        public override string ToString()
        {
            return $"PersonId: {this.personId}\nFirstName: {this.firstName}\nLastName: {this.lastName}\nFavoriteColour: {this.favoriteColor}\nAge: {this.age}\nIsWorking: {isWorking}";
        }
    }
}
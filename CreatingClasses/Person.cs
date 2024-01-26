namespace CreatingClasses
{
    public class Person
    {
        private static int idCount = 1;
        
        public int PersonId { get; }

        public string FirstName  { get; }
        
        public string LastName { get; }

        public string FavoriteColor { get; set; }
        
        public int Age { get; }

        public bool IsWorking { get; }

        public Relation Relationship { get; private set; }

        
        public Person(string firstName, string lastName, string favoriteColor, int age, bool isWorking)
        {
            this.PersonId = idCount;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.FavoriteColor = favoriteColor;
            this.Age = age;
            this.IsWorking = isWorking;

            idCount++;
        }


        public void ChangeFavoriteColour(string color)
        {
            this.FavoriteColor = color;
        }
        
        public void AddRelationship(Person person, string type)
        {
            this.Relationship = new Relation(this, person, type);
        }

        public void DisplayPersonInfo()
        {
            Console.WriteLine($"Name = {this.FirstName} {this.LastName}");
        }

        public int GetAgeInTenYears()
        {
            return this.Age + 10;
        }

        public override string ToString()
        {
            return $"PersonId: {this.PersonId}\n" +
                   $"FirstName: {this.FirstName}\n" +
                   $"LastName: {this.LastName}\n" +
                   $"FavoriteColour: {this.FavoriteColor}\n" +
                   $"Age: {this.Age}\n" +
                   $"IsWorking: {IsWorking}";
        }
    }
}
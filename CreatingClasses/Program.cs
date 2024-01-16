namespace CreatingClasses;

class Program
{
    static void Main(String[] args)
    {
        // Create all of the person objects
        Person ian = new Person("Ian", "Brooks", "Red", 30, true);
        Person gina = new Person("Gina", "James", "Green", 18, false);
        Person mike = new Person("Mike", "Briscoe", "Blue", 45, true);
        Person mary = new Person("Mary", "Beals", "Yellow", 28, true);
        
        // print out gina's information in a sentence
        Console.WriteLine($"{gina.GetPersonId()}: {gina.GetFirstName()} {gina.GetLastName()} favorite colour is: {gina.GetFavoriteColour()}");
        
        // print out mike's information
        Console.WriteLine(mike);
        
        // change ian's favorite colour to white and display
        ian.ChangeFavoriteColour("White");
        Console.WriteLine($"{ian.GetPersonId()}: Ian Brook's favorite colour is: {ian.GetFavoriteColour()}");
        
        // display mary's age in 10 years
        Console.WriteLine($"{mary.GetFirstName()} {mary.GetLastName()} Age in 10 years is: {mary.GetAgeInTenYears()}");
        
        // create relationships and display them
        gina.AddRelationship(mary, "Sisterhood");
        mary.AddRelationship(gina, "Sisterhood");
        ian.AddRelationship(mike, "Brotherhood");
        mike.AddRelationship(ian, "Brotherhood");
        Relation.ShowRelationship(gina, mary);
        Relation.ShowRelationship(ian, mike);

        // create a list of people
        Person[] people = {ian, gina, mike, mary};

        int totalAge = 0;
        Person youngest = null;
        Person oldest = null;
        Person personWhoLikesBlue = null;
        
        // Loop through every person in the array, add each age to the total age.
        // If the person is either younger than the youngest or older than the oldest, change the variable
        // if they like blue, set that variable.
        foreach (Person p in people)
        {
            totalAge += p.GetAge();

            if (youngest == null)
            {
                youngest = p;
            }
            else
            {
                if (youngest.GetAge() > p.GetAge())
                    youngest = p;
            }
            
            
            if (oldest == null)
            {
                oldest = p;
            }
            else
            {
                if (oldest.GetAge() < p.GetAge())
                    oldest = p;
            }

            if (p.GetFavoriteColour() == "Blue")
            {
                personWhoLikesBlue = p;
            }
            
        }
        
        // calculate the average age, then display all of the information from above.
        decimal averageAge = (decimal) totalAge / people.Length;
        
        Console.WriteLine($"Average age is: {averageAge}");
        Console.WriteLine("The youngest person is: " + youngest.GetFirstName());
        Console.WriteLine("The oldest person is: " + oldest.GetFirstName());
        
        Console.WriteLine(personWhoLikesBlue.ToString());
        Console.WriteLine(youngest.ToString());
        Console.WriteLine(oldest.ToString());
    }
}
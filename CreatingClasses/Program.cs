using System;

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
        Console.WriteLine($"{gina.PersonId}: {gina.FirstName} {gina.LastName} favorite colour is: {gina.FavoriteColor}");

        // print out mike's information
        Console.WriteLine(mike);

        // change ian's favorite colour to white and display
        ian.ChangeFavoriteColour("White");
        Console.WriteLine($"{ian.PersonId}: Ian Brook's favorite colour is: {ian.FavoriteColor}");

        // display mary's age in 10 years
        Console.WriteLine($"{mary.FirstName} {mary.LastName} Age in 10 years is: {mary.GetAgeInTenYears()}");

        // create relationships and display them
        gina.AddRelationship(mary, "Sisterhood");
        mary.AddRelationship(gina, "Sisterhood");
        ian.AddRelationship(mike, "Brotherhood");
        mike.AddRelationship(ian, "Brotherhood");
        Relation.ShowRelationship(gina, mary);
        Relation.ShowRelationship(ian, mike);

        // create a list of people
        Person[] people = { ian, gina, mike, mary };

        int totalAge = 0;
        Person youngest = null;
        Person oldest = null;
        Person personWhoLikesBlue = null;

        // Loop through every person in the array, add each age to the total age.
        // If the person is either younger than the youngest or older than the oldest, change the variable
        // if they like blue, set that variable.
        foreach (Person p in people)
        {
            totalAge += p.Age;

            if (youngest == null)
            {
                youngest = p;
            }
            else
            {
                if (youngest.Age > p.Age)
                    youngest = p;
            }


            if (oldest == null)
            {
                oldest = p;
            }
            else
            {
                if (oldest.Age < p.Age)
                    oldest = p;
            }

            if (p.FavoriteColor == "Blue")
            {
                personWhoLikesBlue = p;
            }

        }

        // calculate the average age, then display all of the information from above.
        decimal averageAge = (decimal)totalAge / people.Length;

        Console.WriteLine($"Average age is: {averageAge}");
        Console.WriteLine("The youngest person is: " + youngest.FirstName);
        Console.WriteLine("The oldest person is: " + oldest.FirstName);

        Console.WriteLine(personWhoLikesBlue.ToString());
        Console.WriteLine(youngest.ToString());
        Console.WriteLine(oldest.ToString());
    }
}
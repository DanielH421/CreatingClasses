namespace CreatingClasses;

public class Relation
{
    private String relationshipType;
    private int person1ID;
    private int person2ID;

    // Constructor. Creates a relationship between two people.
    public Relation(Person person1, Person person2, String type)
    {
        this.person1ID = person1.PersonId;
        this.person2ID = person2.PersonId;
        this.relationshipType = type;
    }
    
    // Get the id of person1
    public int getPerson1ID()
    {
        return this.person1ID;
    }
    
    // Get the id of person2
    public int getPerson2ID()
    {
        return this.person2ID;
    }
    
    // Get the relationship type between the two people
    public String getRelationshipType()
    {
        return this.relationshipType;
    }
    
    // Prints the relationship between two given people
    public static void ShowRelationship(Person person, Person relatedTo)
    {
        String relationship = "Strangers";

        Relation r = person.Relationship;

        if (r.getPerson1ID() == relatedTo.PersonId || r.getPerson2ID() == relatedTo.PersonId)
        {
            relationship = r.getRelationshipType();
        }

        Console.WriteLine($"Relationship between {person.FirstName} and {relatedTo.LastName} is: {relationship}");
    } 
}
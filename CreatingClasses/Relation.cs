namespace CreatingClasses;

public class Relation
{
    private String relationshipType;
    private int person1ID;
    private int person2ID;

    // Constructor. Creates a relationship between two people.
    public Relation(Person person1, Person person2, String type)
    {
        this.person1ID = person1.GetPersonId();
        this.person2ID = person2.GetPersonId();
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

        Relation r = person.GetRelationship();

        if (r.getPerson1ID() == relatedTo.GetPersonId() || r.getPerson2ID() == relatedTo.GetPersonId())
        {
            relationship = r.getRelationshipType();
        }

        Console.WriteLine($"Relationship between {person.GetFirstName()} and {relatedTo.GetFirstName()} is: {relationship}");
    } 
}
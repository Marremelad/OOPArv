namespace OOPArv;

public class Leopard : Animal
{
    public int NumberOfSpots { get; set; }

    public Leopard(string name, string color, int age, bool likesHumans, int numberOfSpots) :
        base(AnimalSpecies.Leopard, name, color, age, likesHumans)
    {
        NumberOfSpots = numberOfSpots;
    }
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year {Species} is showing of his {NumberOfSpots} spots.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} roars!!!");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} the {Species} is sleeping...");
    }

    public void Climb()
    {
        Console.WriteLine($"{Name} the {Species} climbs a tree.");
    }
}
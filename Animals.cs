namespace OOPArv;

// Leopard Class.
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

    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and tries to bite you!");
    }
    
    public void Climb()
    {
        Console.WriteLine($"{Name} the {Species} climbs a tree.");
    }
}

// Tiger Class.
public class Tiger : Animal
{
    public int NumberOfStripes { get; set; }

    public Tiger(string name, string color, int age, bool likesHumans, int numberOfStripes) :
        base(AnimalSpecies.Tiger, name, color, age, likesHumans)
    {
        NumberOfStripes = numberOfStripes;
    }

    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year {Species} is showing of its {NumberOfStripes} spots.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} roars!!!");
    }
        
    public override void Sleep()
    {
        Console.WriteLine($"{Name} the {Species} is sleeping...");
    }
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and tries to bite you!");
    }
    
    public void SharpenClaws()
    {
        Console.WriteLine($"{Name} the {Species} is sharpening its claws");
    }
}
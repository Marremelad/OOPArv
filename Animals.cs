namespace OOPArv;

public abstract class Animal
{
    public AnimalSpecies Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }   
    public int Age { get; set; }
    public bool LikesHumans { get; set; }

    public Animal(AnimalSpecies species, string name, string color, int age, bool likesHumans)
    {
        Species = species;
        Name = name;
        Color = color;
        Age = age;
        LikesHumans = likesHumans;
    }

    public abstract void DisplayAnimal();
    public abstract void MakeSound();
    public abstract void Sleep();
    public abstract void Pet();
}

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
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and tries to scratch you!");
    }
    
    public void SharpenClaws()
    {
        Console.WriteLine($"{Name} the {Species} is sharpening its claws");
    }
}

// Elephant class.
public class Elephant : Animal
{
    public int Weight { get; set; }
    
    public Elephant(string name, string color, int age, bool likesHumans, int weight) :
        base(AnimalSpecies.Elephant, name, color, age, likesHumans)
    {
        Weight = weight;
    }
    
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year {Species} is swinging around its weight {Weight}kg.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} makes a trumpet like sound!!!");
    }
        
    public override void Sleep()
    {
        Console.WriteLine($"{Name} the {Species} is sleeping...");
    }
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and tries to stomp on you!");
    }
    
}

public class Zebra : Animal
{
    public int Speed { get; set; }
    
    public Zebra(string name, string color, int age, bool likesHumans, int speed) :
        base(AnimalSpecies.Zebra, name, color, age, likesHumans)
    {
        Speed = speed;
    }
    
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year {Species} is running around at a speed of {Speed}km/h.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} brays!!!");
    }
        
    public override void Sleep()
    {
        Console.WriteLine($"{Name} the {Species} is sleeping...");
    }
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and tries to kick you!");
    }
}

public class Wolf : Animal
{
    public string EyeColor { get; set; }
    
    public Wolf(string name, string color, int age, bool likesHumans, string eyeColor) :
        base(AnimalSpecies.Wolf, name, color, age, likesHumans)
    {
        EyeColor = eyeColor;
    }
    
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year {Species} is looking at you with its {EyeColor} eyes.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} Howls!!!");
    }
        
    public override void Sleep()
    {
        Console.WriteLine($"{Name} the {Species} is sleeping...");
    }
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and growls at you!");
    }
}
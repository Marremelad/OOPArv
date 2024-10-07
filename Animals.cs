namespace OOPArv;

// Leopard Class.
public class Leopard : NonHuman
{
    private int NumberOfSpots { get; set; }
   
    public Leopard(string name, int age, Color color, bool likesHumans, int numberOfSpots) :
        base(AnimalSpecies.Leopard, name, age, color, likesHumans)
    {
        NumberOfSpots = numberOfSpots;
    }

    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Color} {Species} is showing of it's {NumberOfSpots} spots.");
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} roars!!!");
    }

    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : 
            $"{Name} the {Species} gets angry and tries to scratch you!");
    }
    
    public void Climb()
    {
        Console.WriteLine($"{Name} the {Species} climbs a tree.");
    }
}

// Tiger Class.
public class Tiger : NonHuman
{
    private int NumberOfStripes { get; set; }

    public Tiger(string name, int age, Color color, bool likesHumans, int numberOfStripes) :
        base(AnimalSpecies.Tiger, name, age, color, likesHumans)
    {
        NumberOfStripes = numberOfStripes;
    }

    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is showing of its {NumberOfStripes} stripes.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} roars!!!");
    }
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" :
            $"{Name} the {Species} gets angry and tries to scratch you!");
    }
    
    public void SharpenClaws()
    {
        Console.WriteLine($"{Name} the {Species} is sharpening its claws.");
    }
}

// Elephant class.
public class Elephant : NonHuman
{
    private int Weight { get; set; }
    
    public Elephant(string name, int age, Color color, bool likesHumans, int weight) :
        base(AnimalSpecies.Elephant, name, age, color, likesHumans)
    {
        Weight = weight;
    }
    
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is swinging around its weight {Weight}kg.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} makes a trumpet like sound!!!");
    } 
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and tries to stomp on you!");
    }
 
    public void SprayWater()
    {
        Console.WriteLine($"{Name} the {Species} sprays water with it's trunk!");
    }
    
}

public class Zebra : NonHuman
{
    private int Speed { get; set; }
    
    public Zebra(string name, int age, Color color, bool likesHumans, int speed) :
        base(AnimalSpecies.Zebra, name, age, color, likesHumans)
    {
        Speed = speed;
    }
    
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is running around at a speed of {Speed}km/h.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} brays!!!");
    }
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and tries to kick you!");
    }

    public void RotateEars()
    {
        Console.WriteLine($"{Name} then {Species} rotates it's ears 180 degrees.");
    }
}

public class Wolf : NonHuman
{
    private Color EyeColor { get; set; }
    
    public Wolf(string name, int age, Color color, bool likesHumans, Color eyeColor) :
        base(AnimalSpecies.Wolf, name, age, color, likesHumans)
    {
        EyeColor = eyeColor;
    }
    
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is looking at you with its {EyeColor} eyes.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} Howls!!!");
    }
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle" : $"{Name} the {Species} gets angry and growls at you!");
    }

    public void GatherPack()
    {
        Console.WriteLine($"{Name} the {Species} gathers the pack.");
    }
}

public class Puppy : Wolf
{
    private Size Size { get; set; }

    public Puppy(string name, int age, Color color, bool likesHumans, Color eyeColor, Size size) :
        base(name, age, color, likesHumans, eyeColor)
    {
        Size = size;
    }
    
    protected override void SetAge(int age)
    {
        if (age is < 0 or > 2)
        {
            Console.WriteLine("A puppy's age must be in the range of 0 and 2.");
            Age = 1;
        }
        else Age = age;
    }
    
    public void DisplaySize()
    {
        Console.WriteLine($"{Name} the {Species} is a {Size} puppy.");
    }
}


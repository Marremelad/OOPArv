namespace OOPArv;

// Leopard Class.
public class Leopard : NonHuman
{
    private int NumberOfSpots { get; set; }
   
    public Leopard(string name, int age, Color color, bool likesHumans, int numberOfSpots) :
        base(AnimalSpecies.Leopard, AnimalType.Mammal ,name, age, color, likesHumans)
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
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle." : 
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
        base(AnimalSpecies.Tiger, AnimalType.Mammal, name, age, color, likesHumans)
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
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle." :
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
        base(AnimalSpecies.Elephant, AnimalType.Mammal, name, age, color, likesHumans)
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

// Zebra class.
public class Zebra : NonHuman
{
    private int Speed { get; set; }
    
    public Zebra(string name, int age, Color color, bool likesHumans, int speed) :
        base(AnimalSpecies.Zebra, AnimalType.Mammal, name, age, color, likesHumans)
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

// Wolf class.
public class Wolf : NonHuman
{
    private Color EyeColor { get; set; }
    
    public Wolf(string name, int age, Color color, bool likesHumans, Color eyeColor) :
        base(AnimalSpecies.Wolf, AnimalType.Mammal, name, age, color, likesHumans)
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

// Crocodile class.
public class Crocodile : NonHuman
{
    private int NumberOfTeeth { get; set; }
    
    public Crocodile(string name, int age, Color color, int numberOfTeeth) :
        base(AnimalSpecies.Crocodile, AnimalType.Reptile, name, age, color, false)
    {
        NumberOfTeeth = numberOfTeeth;
    }
    
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is resting on the river bank. You can see some it's {NumberOfTeeth} teeth sticking out of it's mouth.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} lets out a primal hiss!!!");
    } 
    
    public override void Pet()
    {
        Console.WriteLine($"If you try to get any closer {Name} will rip your arm off.");
    }
 
    public void Stalk()
    {
        Console.WriteLine($"{Name} the {Species} peaks it's eyes above the water and stares at you.");
    }
    
}

// Salamander class.
public class Salamander : NonHuman
{
    private bool HasTail { get; set; }
    
    public Salamander(string name, int age, Color color, bool likesHumans, bool hasTail) :
        base(AnimalSpecies.Salamander, AnimalType.Amphibian, name, age, color, likesHumans)
    {
        HasTail = hasTail;
    }
    
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is floating in the water.");
    }
        
    public override void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} lets out a bubbly sound!!!");
    } 
    
    public override void Pet()
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle." :
            $"{Name} the {Species} gets angry and swims away!");
    }
 
    public void CheckTail()
    {
        Console.WriteLine(HasTail ? $"{Name} the {Species} swings it's tail around happily." :
            $"{Name} the {Species} has no tail. It will probably regenerate in the future.");
    }

    public void RegenerateTail()
    {
        if (HasTail) Console.WriteLine($"{Name} the {Species} already has a tail.");
        else HasTail = true;
    }
}

// Puppy class.
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


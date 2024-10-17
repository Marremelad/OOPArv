namespace OOPArv;

// Leopard class.
public class Leopard : NonHuman, IWild
{
    private int NumberOfSpots { get; set; } // Number of spots the leopard has.
   
    public Leopard(string name, int age, Color color, int numberOfSpots) : // Constructor for the Leopard class.
        base(AnimalSpecies.Leopard, AnimalType.Mammal, name, age, color)
    {
        NumberOfSpots = numberOfSpots;
    }

    public override void DisplayAnimal() // Method to display the leopard's information.
    {
        Console.WriteLine($"{Name} the {Color} {Species} is showing off its {NumberOfSpots} spots.");
    }

    public override void MakeSound() // Method to display the sound the leopard makes.
    {
        Console.WriteLine($"{Name} the {Species} roars!!!");
    }

    private void Climb() // Method to show that the leopard climbs.
    {
        Console.WriteLine($"{Name} the {Species} climbs a tree.");
    }

    public override void Unique() // Unique behavior for the leopard.
    {
        Climb();
    }
}

// Tiger class.
public class Tiger : NonHuman, IWild
{
    private int NumberOfStripes { get; set; } // Number of stripes the tiger has.

    public Tiger(string name, int age, Color color, int numberOfStripes) : // Constructor for the Tiger class.
        base(AnimalSpecies.Tiger, AnimalType.Mammal, name, age, color)
    {
        NumberOfStripes = numberOfStripes;
    }

    public override void DisplayAnimal() // Method to display the tiger's information.
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is showing off its {NumberOfStripes} stripes.");
    }

    public override void MakeSound() // Method to display the sound the tiger makes.
    {
        Console.WriteLine($"{Name} the {Species} roars!!!");
    }

    private void SharpenClaws() // Method to show that the tiger sharpens its claws.
    {
        Console.WriteLine($"{Name} the {Species} is sharpening its claws.");
    }

    public override void Unique() // Unique behavior for the tiger.
    {
        SharpenClaws();
    }
}

// Elephant class.
public class Elephant : NonHuman, ITame
{
    private int Weight { get; set; } // Weight of the elephant.
    public bool LikesHumans { get; set; } // Whether the elephant likes humans or not.

    public Elephant(string name, int age, Color color, bool likesHumans, int weight) : // Constructor for the Elephant class.
        base(AnimalSpecies.Elephant, AnimalType.Mammal, name, age, color)
    {
        Weight = weight;
        LikesHumans = likesHumans;
    }

    public override void DisplayAnimal() // Method to display the elephant's information.
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is walking around. He weighs {Weight}kg.");
    }

    public override void MakeSound() // Method to display the sound the elephant makes.
    {
        Console.WriteLine($"{Name} the {Species} makes a trumpet-like sound!!!");
    }

    public void TryPet() // Method to show how the elephant reacts to being petted.
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle." :
            $"{Name} the {Species} gets angry and tries to stomp on you!");
    }

    private void SprayWater() // Method to show that the elephant sprays water.
    {
        Console.WriteLine($"{Name} the {Species} sprays water with its trunk!");
    }

    public override void Unique() // Unique behavior for the elephant.
    {
        SprayWater();
    }
}

// Zebra class.
public class Zebra : NonHuman, IWild
{
    private int Speed { get; set; } // Speed of the zebra.

    public Zebra(string name, int age, Color color, int speed) : // Constructor for the Zebra class.
        base(AnimalSpecies.Zebra, AnimalType.Mammal, name, age, color)
    {
        Speed = speed;
    }

    public override void DisplayAnimal() // Method to display the zebra's information.
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is running around at a speed of {Speed}km/h.");
    }

    public override void MakeSound() // Method to display the sound the zebra makes.
    {
        Console.WriteLine($"{Name} the {Species} brays!!!");
    }

    private void RotateEars() // Method to show that the zebra rotates its ears.
    {
        Console.WriteLine($"{Name} the {Species} rotates its ears 180 degrees listening for predators.");
    }

    public override void Unique() // Unique behavior for the zebra.
    {
        RotateEars();
    }
}

// Wolf class.
public class Wolf : NonHuman, ITame
{
    private Color EyeColor { get; set; } // Eye color of the wolf.
    public bool LikesHumans { get; set; } // Whether the wolf likes humans or not.

    public Wolf(string name, int age, Color color, bool likesHumans, Color eyeColor) : // Constructor for the Wolf class.
        base(AnimalSpecies.Wolf, AnimalType.Mammal, name, age, color)
    {
        EyeColor = eyeColor;
        LikesHumans = likesHumans;
    }

    public override void DisplayAnimal() // Method to display the wolf's information.
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is looking at you with its {EyeColor} eyes.");
    }

    public override void MakeSound() // Method to display the sound the wolf makes.
    {
        Console.WriteLine($"{Name} the {Species} howls!!!");
    }

    public void TryPet() // Method to show how the wolf reacts to being petted.
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle." :
            $"{Name} the {Species} gets angry and growls at you!");
    }

    private void GatherPack() // Method to show that the wolf gathers its pack.
    {
        Console.WriteLine($"{Name} the {Species} gathers the pack.");
    }

    public override void Unique() // Unique behavior for the wolf.
    {
        GatherPack();
    }
}

// Crocodile class.
public class Crocodile : NonHuman, IWild
{
    private int NumberOfTeeth { get; set; } // Number of teeth the crocodile has.

    public Crocodile(string name, int age, Color color, int numberOfTeeth) : // Constructor for the Crocodile class.
        base(AnimalSpecies.Crocodile, AnimalType.Reptile, name, age, color)
    {
        NumberOfTeeth = numberOfTeeth;
    }

    public override void DisplayAnimal() // Method to display the crocodile's information.
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is resting on the river bank. You can see some of its {NumberOfTeeth} teeth sticking out of its mouth.");
    }

    public override void MakeSound() // Method to display the sound the crocodile makes.
    {
        Console.WriteLine($"{Name} the {Species} lets out a primal hiss!!!");
    }

    private void Stalk() // Method to show that the crocodile stalks its prey.
    {
        Console.WriteLine($"{Name} the {Species} peeks its eyes above the water and stares at you.");
    }

    public override void Unique() // Unique behavior for the crocodile.
    {
        Stalk();
    }
}

// Salamander class.
public class Salamander : NonHuman, ITame
{
    private bool HasTail { get; set; } // Whether the salamander has a tail or not.
    public bool LikesHumans { get; set; } // Whether the salamander likes humans or not.

    public Salamander(string name, int age, Color color, bool likesHumans, bool hasTail) : // Constructor for the Salamander class.
        base(AnimalSpecies.Salamander, AnimalType.Amphibian, name, age, color)
    {
        HasTail = hasTail;
        LikesHumans = likesHumans;
    }

    public override void DisplayAnimal() // Method to display the salamander's information.
    {
        Console.WriteLine($"{Name} the {Age} year old {Color} colored {Species} is floating in the water.");
    }

    public override void MakeSound() // Method to display the sound the salamander makes.
    {
        Console.WriteLine($"{Name} the {Species} lets out a bubbly sound!!!");
    }

    public void TryPet() // Method to show how the salamander reacts to being petted.
    {
        Console.WriteLine(LikesHumans ? $"{Name} the {Species} likes to cuddle." :
            $"{Name} the {Species} gets angry and swims away!");
    }

    public void CheckTail() // Method to check if the salamander has a tail.
    {
        Console.WriteLine(HasTail ? $"{Name} the {Species} swings its tail around happily." :
            $"{Name} the {Species} has no tail. It will probably regenerate in the future.");
    }

    private void RegenerateTail() // Method to show that the salamander regenerates its tail.
    {
        if (HasTail) Console.WriteLine($"{Name} the {Species} already has a tail.");
        else HasTail = true;
    }

    public override void Unique() // Unique behavior for the salamander.
    {
        RegenerateTail();
    }
}

// Puppy class.
public class Puppy : Wolf
{
    private Size Size { get; set; } // Size of the puppy.

    public Puppy(string name, int age, Color color, bool likesHumans, Color eyeColor, Size size) : // Constructor for the Puppy class.
        base(name, age, color, likesHumans, eyeColor)
    {
        Size = size;
    }

    protected override void SetAge(int age) // Method to set the age of the puppy.
    {
        if (age is < 0 or > 2)
        {
            Console.WriteLine("A puppy's age must be in the range of 0 and 2.");
            Age = 1;
        }
        else Age = age;
    }

    public void DisplaySize() // Method to display the puppy's size.
    {
        Console.WriteLine($"{Name} the {Species} is a {Size} puppy.");
    }
}

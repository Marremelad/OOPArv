namespace OOPArv;

// Animal class.
public abstract class Animal
{
    protected AnimalSpecies Species { get; set; } // Species of the animal.
    private AnimalType AnimalType { get; set; } // Type of the animal (Mammal, Reptile, etc.).
    protected string Name { get; set; } // Name of the animal.
    protected int Age; // Age of the animal.
    
    protected Animal(AnimalSpecies species, AnimalType animalType, string name, int age) // Constructor for the Animal class.
    {
        Species = species;
        AnimalType = animalType;
        Name = name;
        GetSetter(age);
    }

    public int GetAge() // Method to retrieve the animal's age.
    {
        return Age;
    }
    
    private void GetSetter(int age) // Private method to set the age.
    {
        SetAge(age);
    }

    protected virtual void SetAge(int age) // Protected method to validate and set the age.
    {
        if (age < 1)
        {
            Console.WriteLine("An animals age can not be less than 1.");
            Age = 1;
        }
        else Age = age;
    }

    public void DisplayAnimalType() // Method to display the animal's type.
    {
        switch (AnimalType)
        {
            case AnimalType.Mammal:
                Console.WriteLine($"{Name} the {Species} is a mammal. Mammals are warm-blooded vertebrates that have hair or fur and produce milk to feed their young.");
                break;
            case AnimalType.Reptile:
                Console.WriteLine($"{Name} the {Species} is a reptile. Reptiles are cold-blooded vertebrates that typically lay eggs and have scaly skin, which helps prevent water loss.");
                break;
            case AnimalType.Amphibian:
                Console.WriteLine($"{Name} the {Species} is an amphibian. Amphibians are cold-blooded vertebrates that typically begin their life cycle in water with gills and undergo metamorphosis to develop lungs for breathing air as adults.");
                break;
        }
    }

    public virtual void MakeSound() // Virtual method to make an animal sound.
    {
        Console.WriteLine($"{Name} the {Species} makes a sound!");
    }

    public virtual void Sleep() // Virtual method to indicate the animal is sleeping.
    {
        Console.WriteLine($"{Name} the {Species} is sleeping...");
    }
}

// Human class.
public class Human : Animal
{
    public string? Occupation { get; set; } // Occupation of the human.

    public Human(string name, int age, string occupation) : base(AnimalSpecies.Human, AnimalType.Mammal, name, age) // Constructor for the Human class.
    {
        Occupation = occupation;
    }
    
    protected override void SetAge(int age) // Override of SetAge method for humans.
    {
        if (age < 1)
        {
            Console.WriteLine("Age has to be more than 0.");
            Age = 1;
        }
        else Age = age;
    }
    
    public void DisplayInformation() // Method to display human's information.
    {
        Console.WriteLine($"{Name} the {Occupation} is {Age} years old.");
    }

    public void Greet() // Method to display a greeting.
    {
        Console.WriteLine($"{Name} says hello!");
    }

    public override void Sleep() // Override of the Sleep method for humans.
    {
        Console.WriteLine($"{Name} is tired and goes home to sleep...");
    }
}

// NonHuman class.
public abstract class NonHuman : Animal
{
    protected Color Color { get; set; } // Color of the animal.

    public NonHuman(AnimalSpecies species, AnimalType animalType, string name, int age, Color color) // Constructor for the NonHuman class.
        : base(species, animalType, name, age)
    {
        Color = color;
    }
    
    public abstract void DisplayAnimal(); // Abstract method to display animal details.

    public abstract void Unique(); // Abstract method to display unique behavior of the animal.
}

// Plant class.
public class Plant
{
    public PlantSpecies Species { get; set; } // Species of the plant.
    public Color Color { get; set; } // Color of the plant.

    public Plant(PlantSpecies plantSpecies, Color color) // Constructor for the Plant class.
    {
        Species = plantSpecies;
        Color = color;
    }

    public void DisplayPlant() // Method to display plant details.
    {
        Console.WriteLine($"This {Color} {Species} is standing tall out in the sun.");
    }
}

namespace OOPArv;

// Animal class.
public abstract class Animal
{
    protected AnimalSpecies Species { get; set; }
    protected AnimalType AnimalType { get; set; }
    protected string Name { get; set; }
    protected int Age;
    protected Color Color { get; set; }

    protected Animal(AnimalSpecies species, AnimalType animalType, string name, int age, Color color)
    {
        Species = species;
        AnimalType = animalType;
        Name = name;
        Color = color;
        GetSetter(age);
    }

    public int GetAge()
    {
        return Age;
    }
    
    private void GetSetter(int age)
    {
        SetAge(age);
    }

    protected virtual void SetAge(int age)
    {
        if (age < 1)
        {
            Console.WriteLine("An animals age can not be less than 1.");
            Age = 1;
        }
        else Age = age;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine($"{Name} the {Species} makes a sound!");
    }

    public virtual void Sleep()
    {
        Console.WriteLine($"{Name} the {Species} is sleeping...");
    }
}

//Human class.
public abstract class Human(string name, int age, Color color)
    : Animal(AnimalSpecies.Human,AnimalType.Mammal, name, age, color)
{
    protected override void SetAge(int age)
    {
        if (age < 1)
        {
            Console.WriteLine("Age has to be more than 0.");
            Age = 1;
        }
        else Age = age;
    }
    
    public void DisplayInformation()
    {
        Console.WriteLine();
    }

    public void Greet()
    {
        Console.WriteLine($"{Name} says hello!");
    }

    public override void Sleep()
    {
        Console.WriteLine($"{Name} is tired and goes home to sleep...");
    }
}

// NonHuman class.
public abstract class NonHuman(AnimalSpecies species, AnimalType animalType, string name, int age, Color color, bool likesHumans)
    : Animal(species, animalType, name, age, color)
{
    protected bool LikesHumans { get; set; } = likesHumans;

    public abstract void DisplayAnimal();

    public abstract void Pet();
}
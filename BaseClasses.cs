﻿using System.Data;

namespace OOPArv;

// Animal class.
public abstract class Animal
{
    protected AnimalSpecies Species { get; set; }
    private AnimalType AnimalType { get; set; }
    protected string Name { get; set; }
    protected int Age;
    
    protected Animal(AnimalSpecies species, AnimalType animalType, string name, int age)
    {
        Species = species;
        AnimalType = animalType;
        Name = name;
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

    public void DisplayAnimalType()
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
public class Human : Animal
{
    public string? Occupation { get; set; }
    public Human(string name, int age, string occupation) :base(AnimalSpecies.Human, AnimalType.Mammal, name, age)
    {
        Occupation = occupation;
    }
    
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
        Console.WriteLine($"{Name} is {Age} years old.");
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
public abstract class NonHuman(AnimalSpecies species, AnimalType animalType, string name, int age, Color color)
    : Animal(species, animalType, name, age)
{
    protected Color Color { get; set; }
    public abstract void DisplayAnimal();
    
    public abstract void Unique();
}

// Plant class.
public class Plant
{
    public PlantSpecies Species { get; set; }
    public Color Color { get; set; }

    public Plant(PlantSpecies plantSpecies, Color color)
    {
        Species = plantSpecies;
        Color = color;
    }

    public void DisplayPlant()
    {
        Console.WriteLine($"This {Color} {Species} is standing tall out in the sun.");
    }
}
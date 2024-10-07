namespace OOPArv;

public class Human(string name, int age, Color color)
    : Animal(AnimalSpecies.Human, name, age, color)
{
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

public abstract class NonHuman(AnimalSpecies species, string name, int age, Color color, bool likesHumans)
    : Animal(species, name, age, color)
{
    protected bool LikesHumans { get; set; } = likesHumans;

    public abstract void DisplayAnimal();

    public abstract void Pet();
}
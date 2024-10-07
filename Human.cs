namespace OOPArv;

public class Human(string name, int age, Color color, bool likesOtherHumans)
    : Animal(AnimalSpecies.Human, name, age, color, likesOtherHumans)
{
    public override void DisplayAnimal()
    {
        Console.WriteLine($"{Name} is {Age} years old and has {Color} skin color." );
    }
    
    public override void Sleep()
    {
        Console.WriteLine($"{Name} is tired and goes home to sleep...");
    }
    
    public void Greet()
    {
        Console.WriteLine($"{Name} says hello!");
    }
    
}
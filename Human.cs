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
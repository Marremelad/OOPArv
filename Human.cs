namespace OOPArv;

public class Human(string name, int age, Color color, bool likesOtherHumans)
    : Animal(AnimalSpecies.Human, name, age, color, likesOtherHumans)
{
    public void Greet()
    {
        Console.WriteLine($"{Name} says hello!");
    }
}
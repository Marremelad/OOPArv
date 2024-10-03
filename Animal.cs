namespace OOPArv;

public abstract class Animal
{
    public AnimalSpecies Species { get; set; }
    public string Name { get; set; }
    public string Color { get; set; }   
    public int Age { get; set; }
    public bool LikesHumans { get; set; }

    public Animal(AnimalSpecies species, string name, string color, int age, bool likesHumans)
    {
        Species = species;
        Name = name;
        Color = color;
        Age = age;
        LikesHumans = likesHumans;
    }

    public abstract void DisplayAnimal();
    public abstract void MakeSound();
    public abstract void Sleep();
    public abstract void Pet();
}
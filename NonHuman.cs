namespace OOPArv;

public abstract class NonHuman : Animal
{
    protected bool LikesHumans { get; set; }

    public NonHuman(AnimalSpecies species, string name, int age, Color color, bool likesHumans) :
        base (species, name, age, color)
    {
        LikesHumans = likesHumans;
    }

    public abstract void DisplayAnimal();

    public abstract void Pet();
}
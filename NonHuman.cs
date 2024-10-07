namespace OOPArv;

public class NonHuman : Animal, INonHuman
{
    public bool LikesHumans { get; set; }

    public NonHuman(AnimalSpecies species, string name, int age, Color color, bool likesHumans) :
        base (species, name, age, color)
    {
        LikesHumans = likesHumans;
    }

    public virtual void DisplayAnimal()
    {
        throw new NotImplementedException();
    }

    public virtual void Pet()
    {
        throw new NotImplementedException();
    }
}
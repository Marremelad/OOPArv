namespace OOPArv;

public interface ITame
{
    public bool LikesHumans { get; set; }
    public void TryPet();
}

public interface IWild
{
    public void RoamWild()
    {
        Console.WriteLine("The animal is roaming in the wild.");
    }
}
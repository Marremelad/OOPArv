namespace OOPArv;

// Interface for tame animals.
public interface ITame
{
    public bool LikesHumans { get; set; } // Property indicating if the animal likes humans.
    public void TryPet(); // Method to attempt petting the animal.
}

// Interface for wild animals.
public interface IWild
{
    public void RoamWild() // Method for wild animals to roam in the wild.
    {
        Console.WriteLine("The animal is roaming in the wild.");
    }
}
//Lab 6 - OOP Arv
//Mauricio Corte
//.NET 24

namespace OOPArv;

class Program
{
    static void Main(string[] args) // Main entry point of the program.
    {
        string separator = "------------------------------------------"; // Separator for console output.
        
        List<NonHuman> listOfAnimals = // List of NonHuman animals.
        [
            new Leopard("Lucas", 10, Color.Yellow, 500),
            // new Tiger("Tony", 5, Color.Orange, 300),
            new Elephant("Erik", 20, Color.Gray, true, 5000),
            // new Zebra("Zack", 15, Color.White, 55),
            // new Wolf("Wayne", 7, Color.Black, false, Color.Blue),
            // new Puppy("Pall", 1, Color.Brown, true, Color.Gold, Size.Fat),
            new Crocodile("Cain", 19, Color.Green, 100),
        ];

        foreach (var animal in listOfAnimals) // Loop through each animal in the list.
        {
            animal.DisplayAnimalType();
            animal.DisplayAnimal();
            animal.Sleep();
            animal.MakeSound();
            animal.Unique();
            
            if (animal is IWild wildAnimal) wildAnimal.RoamWild(); // Check if animal is wild.
            else if (animal is ITame tameAnimal) tameAnimal.TryPet(); // Check if animal is tame.
            
            Console.WriteLine(separator);
        }
        
        Salamander salamander = new Salamander("Sally", 2, Color.Red, true, false); // Salamander object.
        salamander.DisplayAnimalType();
        salamander.CheckTail();
        salamander.Unique();
        salamander.CheckTail();
        Console.WriteLine(separator);

        Human human = new Human("Mauricio", 26, "Student"); // Human object.
        
        human.DisplayInformation();
        human.Greet();
        human.Sleep();
        Console.WriteLine(separator);

        List<Plant> listOfPlants = new List<Plant>() // List of plants.
        {
            new Plant(PlantSpecies.Orchid, Color.White),
            new Plant(PlantSpecies.Sunflower, Color.Yellow),
            new Plant(PlantSpecies.Daisy, Color.Gold)
        };

        foreach (var plant in listOfPlants) // Loop through each plant in the list.
        {
            plant.DisplayPlant();
            Console.WriteLine(separator);
        }
    }
}

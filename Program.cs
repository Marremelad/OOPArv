//Lab 6 - OOP Arv
//Mauricio Corte
//.NET 24

namespace OOPArv;

class Program
{
    static void Main(string[] args)
    {
        List<NonHuman> listOfAnimals =
        [
            new Leopard("Lucas", 10, Color.Yellow, 500),
            // new Tiger("Tony", 5, Color.Orange, 300),
            new Elephant("Erik", 20, Color.Gray, true, 5000),
            // new Zebra("Zack", 15, Color.White, 55),
            // new Wolf("Wayne", 7, Color.Black, false, Color.Blue),
            // new Puppy("Pall", 1, Color.Brown, true, Color.Gold, Size.Fat),
            // new Crocodile("Cain", 19, Color.Green, 100),
            // new Salamander("Sally", 2, Color.Red, true, false),
        ];

        foreach (var animal in listOfAnimals)
        {
            if (animal is IWild wildAnimal) wildAnimal.RoamWild();
            else if (animal is ITame tameAnimal) tameAnimal.TryPet();
            
            animal.DisplayAnimalType();
            animal.DisplayAnimal();
            animal.Sleep();
            animal.MakeSound();
            animal.Unique();
        }
    }
}
//Lab 6 - OOP Arv
//Mauricio Corte
//.NET 24

namespace OOPArv;

class Program
{
    static void Main(string[] args)
    {
        Leopard leopard = new Leopard("Jack", 5, Color.Brown, true, 500);
        Tiger tiger = new Tiger("Oliver", 5, Color.Orange, true, 500);
        Elephant elephant = new Elephant("Babar", 7, Color.Gray, true, 7000);
        Zebra zebra = new Zebra("Super Zebran", 3, Color.White, true, 500);
        Wolf wolf = new Wolf("Balto", 10, Color.Gray, true, Color.Gold);
        Crocodile crocodile = new Crocodile("Snapper", 20, Color.Green, 500);
        Salamander salamander = new Salamander("Sally", 2, Color.Red, true, false);
        Puppy puppy = new Puppy("Asma", 1, Color.Black, false, Color.Brown, Size.Small);
        
        crocodile.DisplayAnimal();
        crocodile.Pet();
        
        salamander.DisplayAnimal();
        salamander.CheckTail();
        salamander.RegenerateTail();
        salamander.CheckTail();
    }
}
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
        
        leopard.DisplayAnimal();
        tiger.DisplayAnimal();
        

    }
}
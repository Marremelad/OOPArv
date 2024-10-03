//Lab 6 - OOP Arv
//Mauricio Corte
//.NET 24

namespace OOPArv;

class Program
{
    static void Main(string[] args)
    {
        Leopard leopard = new Leopard("Bruce", "Yellow and black", 4, true, 500);
        
        leopard.DisplayAnimal();
        leopard.MakeSound();
        leopard.Sleep();
        leopard.Climb();
    }
}
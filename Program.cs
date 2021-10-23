using System;

namespace IInterfaceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Werehouse werehouse = new Werehouse(1, true);
            int amount = werehouse.GivCargo(1500);
            Console.WriteLine($"Amount for Cargo={amount}");
            int count = werehouse.GetCargo(true);
            Console.WriteLine($"Count of cargo={count}");
            Console.WriteLine(new string('_', 50));

            ICargo train = new Train(true, true);
            //int count1= train.GetCargo(true);
            //int amount1 = train.GivCargo(2000);
            //Console.WriteLine($"{count1}={amount1}");
            train.Divide();
            Console.WriteLine(new string('_', 50));

            ICargo airplane = new Airplane(true);
            //int count2 = airplane.GetCargo(true);
            //int amount2 = airplane.GivCargo(3000);
            //Console.WriteLine($"{count2}={amount2}");
            airplane.Divide();
            Console.WriteLine(new string('_', 50));

            ICargo truck = new Truck(true);
            //int count3 = truck.GetCargo(true);
            //int amount3 = truck.GivCargo(1000);
            //Console.WriteLine($"{count3}={amount3}");
            truck.Divide();
            Console.WriteLine(new string('_', 50));
           
            ICargo ship = new Ship(true);
            //int count4 = ship.GetCargo(true);
            //int amount4 = ship.GivCargo(1700);
            //Console.WriteLine($"{count4}={amount4}");
            ship.Divide();
            Console.WriteLine(new string('_',50));
        }
    }
}

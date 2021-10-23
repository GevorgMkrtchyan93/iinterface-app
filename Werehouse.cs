using System;

namespace IInterfaceApp
{
    class Werehouse
    {
        private int _count;
        private bool _cargo;

        public Werehouse(int count, bool cargo)
        {
            _count = count;
            _cargo = cargo;
        }

        public int GivCargo(int amount)
        {
            if (amount >= 1000)
            {
                amount *= _count;
            }
            if (amount <= 1000)
            {
                Console.WriteLine("Return Cargo");
            }
            return amount;
        }
        public int GetCargo(bool freeSpace)
        {
            if (freeSpace)
            {
                _count++;
            }
            else
            {
                Console.WriteLine($"There is no free space");
            }
            return _count;
        }
    }
}

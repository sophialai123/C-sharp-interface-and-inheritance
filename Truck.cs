using System;

namespace LearnInterfaces
{
    class Truck : IAutomobile
    {
        //implement the interface
        public string LicensePlate { get; }

        public double Speed { get; }

        public int Wheels { get; }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }
    }
}

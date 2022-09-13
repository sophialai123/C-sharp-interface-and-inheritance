using System;

namespace LearnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two sedans and a truck objects:
            Sedan sedan = new Sedan(60); //speed
            Sedan sedan2 = new Sedan(70);
            Truck t = new Truck(45, 500); //speed and weight

            Console
                .WriteLine($"{sedan.Speed},{sedan.Wheels},{
                    sedan.LicensePlate}");

            Console
                .WriteLine($"{sedan2.Speed}, {sedan2.Wheels}, {
                    sedan2.LicensePlate}");
            Console.WriteLine($"{t.Speed}, {t.Wheels}, {t.LicensePlate}");
            call method
            sedan.SpeedUp();
            sedan2.SpeedUp();
            t.SpeedUp();
            Console.WriteLine(sedan.Speed);
            Console.WriteLine(sedan2.Speed);
            Console.WriteLine(t.Speed);
        }
    }
}

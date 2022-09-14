using System;

namespace LearnInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create two sedans and a truck objects:
            Sedan s = new Sedan(60); //speed
            Sedan s2 = new Sedan(70);
            Truck t = new Truck(45, 500); //speed and weight
            Bicycle b = new Bicycle(10);

            Console.WriteLine($"{s.Speed}, {s.Wheels}, {s.LicensePlate}");
            Console.WriteLine($"{s2.Speed}, {s2.Wheels}, {s2.LicensePlate}");
            Console.WriteLine($"{t.Speed}, {t.Wheels}, {t.LicensePlate}");

            //call method
            s.SpeedUp();
            s2.SpeedUp();
            t.SpeedUp();
            Console.WriteLine(s.Speed);
            Console.WriteLine(s2.Speed);
            Console.WriteLine(t.Speed);

            //call Describe()method on each instance
            Console.WriteLine(s.Describe());
            Console.WriteLine(b.Describe());
            Console.WriteLine(t.Describe());
        }
    }
}

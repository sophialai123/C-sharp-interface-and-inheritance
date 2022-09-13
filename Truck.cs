using System;

namespace LearnInterfaces
{
    class Truck : IAutomobile
    {
        //constructor
        public Truck(double speed, double weight)
        {
            this.Speed = speed;
            this.Weight = weight;
            LicensePlate = Tools.GenerateLicensePlate();
            if (weight < 400)
            {
                this.Wheels = 8;
            }
            else
            {
                this.Wheels = 12;
            }
        }

        //implement the interface
        public string LicensePlate { get; }

        public double Speed { get; set; }

        public int Wheels { get; }

        public double Weight { get; } //new

        //methods
        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        public void SpeedUp()
        {
            Speed += 5; //need set() interfeace
        }

        public void SlowDown()
        {
            Speed -= 5;
        }
    }
}

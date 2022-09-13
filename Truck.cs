using System;

namespace LearnInterfaces
{
    //inheritance from Vehicle class
    class Truck : Vehicle, IAutomobile
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
        public double Weight { get; }
    }
}

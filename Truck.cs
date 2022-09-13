using System;

namespace LearnInterfaces
{
    //inheritance from Vehicle class
    class Truck : Vehicle, IAutomobile
    {
        //constructor
        //all the superclass constructor using : base(speed)
        public Truck(double speed, double weight) :
            base(speed)
        {
            this.Weight = weight;
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

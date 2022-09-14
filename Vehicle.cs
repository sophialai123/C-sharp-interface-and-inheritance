using System;

namespace LearnInterfaces
{
    //Create a Superclass and make it abstract
    abstract class Vehicle
    {
        //explicitly  define a construtor
        public Vehicle(double speed)
        {
            Speed = speed;
            LicensePlate = Tools.GenerateLicensePlate();
        }

        //properties
        //A protected member can be accessed by
        // the current class and any class that inherits
        public string LicensePlate { get; protected set; }

        public double Speed { get; protected set; }

        public int Wheels { get; protected set; }

        //methods
        public void Honk()
        {
        }

        //virtual method can be override
        public virtual void SpeedUp()
        {
        }

        public virtual void SlowDown()
        {
        }

        //Add the abstract method Describe()
        public abstract string Describe();
    }
}

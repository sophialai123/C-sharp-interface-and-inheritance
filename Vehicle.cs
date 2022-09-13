using System;

namespace LearnInterfaces
{
    //Create a Superclass
    class Vehicle
    {
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

        public void SpeedUp()
        {
        }

        public void SlowDown()
        {
        }
    }
}

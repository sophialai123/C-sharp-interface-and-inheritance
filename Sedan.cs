using System;

namespace LearnInterfaces
{
    //create an empty  class that implements
    // the IAutomobile interface.
    //Sedan inherits the Vehicle class.
    class Sedan : Vehicle, IAutomobile
    {
        //constructor
        public Sedan(double speed)
        {
            this.Speed = speed;
            Wheels = 4;

            //To make a random license plate
            LicensePlate = Tools.GenerateLicensePlate();
        }
    }
}

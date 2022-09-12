using System;

namespace LearnInterfaces
{
    //create an empty  class that implements
    // the IAutomobile interface.
    class Sedan : IAutomobile
    {
        //constructor
        public Sedan(double speed)
        {
            this.Speed = speed;
            Wheels = 4;

            //To make a random license plate
            LicensePlate = Tools.GenerateLicensePlate();
        }

        //Implement the interface by adding
        //the three properties and one method
        //all must to be public
        public string LicensePlate { get; }

        public double Speed { get; set; }

        public int Wheels { get; }

        public void Honk()
        {
            Console.WriteLine("HONK!");
        }

        //methods
        public void SpeedUp()
        {
            Speed += 5;
        }

        public void SlowDown()
        {
            Speed -= 5;
        }
    }
}

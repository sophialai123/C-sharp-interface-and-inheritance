using System;

namespace LearnInterfaces
{
    //create an interface with methods and properties with get method
    interface IAutomobile
    {
        string LicensePlate { get; }

        double Speed { get; }

        int Wheels { get; }

        //method
        void Honk();
    }
}

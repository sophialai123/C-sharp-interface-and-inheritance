using System;

namespace LearnInterfaces
{
    //create an empty  class that implements
    // the IAutomobile interface.
    //Sedan inherits the Vehicle class.
    class Sedan : Vehicle, IAutomobile
    {
        //superclass constructor using : base(speed).
        public Sedan(double speed) :
            base(speed)
        {
        }
    }
}

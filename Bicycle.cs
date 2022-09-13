using System;

namespace LearnInterfaces
{
    //inherits from Vehicle class
    class Bicycle : Vehicle
    {
        //define a constructor call base constructor
        public Bicycle(double speed) :
            base(speed)
        {
            Wheels = 2;
        }

        //Define a public void method with override
        // the parent method
        public override void SpeedUp()
        {
            if (Speed > 15)
            {
                Speed += 15;
            }
            Speed += 5;
        }
    }
}

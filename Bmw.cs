using System;

namespace carGame
{
    class Bmw : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Bmw started");
        }
        public override void Break()
        {
            Console.WriteLine("Bmw Break");
        }
    }
}

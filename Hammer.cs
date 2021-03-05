using System;

namespace carGame
{
    class Hammer : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Hammer started");
        }
        public override void Break()
        {
            Console.WriteLine("Hammer Break");
        }
    }
}

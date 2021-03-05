using System;

namespace carGame
{
    class Benz : Car
    {
        public override void Accelerate()
        {
            Console.WriteLine("Benz started");
        }
        public override void Break()
        {
            Console.WriteLine("Benz Break");
        }
    }
}

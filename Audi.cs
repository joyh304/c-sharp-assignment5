using System;

namespace carGame
{
    class Audi : Car
    {
       public override void Accelerate()
        {
            Console.WriteLine("Audi started");
        }
        public override void Break()
        {
            Console.WriteLine("Benz Break");
        }
    }
}

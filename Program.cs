using System;

namespace carGame
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string option = Console.ReadLine();
                var Car = CarFactory.GetCar(option);
                StartGame(Car);
            }
        }
        public static void StartGame(Car car)
        {
            car.Accelerate();
            car.Break();
        }
    }
}

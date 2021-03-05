using System;

namespace carGame
{
    public static class CarFactory
    {
        public static Car GetCar(string carName)
        {
            var carType = Type.GetType("carGame."+carName);
            var constructor = carType.GetConstructor(new Type[]{});
            var car = (Car)constructor.Invoke(new object[]{});
            return car;
        }
    }
}
using FactoryMethod.Models;
using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ConcriteFactory();
            var bike = factory.GetVehicles("bike");
            var car = factory.GetVehicles("car");
            car.Drive(100);
            bike.Drive(115);
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models
{
    public class Bike : IFactory
    {
        public void Drive(int km)
        {
            Console.WriteLine($"this bike drived {km} km");
        }
    }
}

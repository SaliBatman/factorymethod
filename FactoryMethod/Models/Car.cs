using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod.Models
{
    public class Car : IFactory
    {
        public void Drive(int km) 
        {
            Console.WriteLine($"this car drived {km} km");
        }
    }
}

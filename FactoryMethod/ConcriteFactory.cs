using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class ConcriteFactory : ObjectFactory
    {
        public override IFactory GetVehicles(string vechielType)
        {
            switch (vechielType)
            {
                case "car": return new Car();
                case "bike": return new Bike();
                default:
                    return null;
            }
        }
    }
}

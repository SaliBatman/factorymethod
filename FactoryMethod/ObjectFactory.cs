using FactoryMethod.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class ObjectFactory
    {
        public abstract IFactory GetVehicles(string vechielType);
    }
}

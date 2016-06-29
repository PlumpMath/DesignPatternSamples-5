using System;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    class SBIBank : Bank
    {
        public override string GetName()
        {
            return "State Bank of India";
        }
    }
}

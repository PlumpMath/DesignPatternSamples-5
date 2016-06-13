using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample1
{
    class Tea : CoffeeBeverage
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Adding lemon");
        }

        protected override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }
    }
}

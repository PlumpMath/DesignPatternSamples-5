using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample1
{
    class Coffee : CoffeeBeverage
    {
        protected override void addCondiments()
        {
            Console.WriteLine("Adding sugar and milk");
        }

        protected override void brew()
        {
            Console.WriteLine("Dripping coffee through filter");
        }
    }
}

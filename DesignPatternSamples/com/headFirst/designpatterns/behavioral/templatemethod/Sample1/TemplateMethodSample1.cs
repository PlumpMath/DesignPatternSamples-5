using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample1
{
    class TemplateMethodSample1
    {
        static void Main(string[] args)
        {
            ICoffeeBeverage beverage = new Coffee();

            Console.WriteLine("Making coffee...");
            beverage.PrepareRecipe();

            beverage = new Tea();

            Console.WriteLine("Making tea...");
            beverage.PrepareRecipe();

            Console.Read();
        }
    }
}

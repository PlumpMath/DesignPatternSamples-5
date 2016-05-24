using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    class DecoratorSample2
    {
        static void Main(string[] args)
        {
            Beverage beverage = new Espresso(1.99, BeverageSize.Venti);
            Console.WriteLine("{0} ${1}", beverage.GetDescription(), beverage.GetCost());

            Beverage beverage1 = new DarkRoast(0.99, BeverageSize.Tall);
            beverage1 = new Mocha(beverage1, 0.20);
            beverage1 = new Mocha(beverage1, 0.20);
            beverage1 = new Whip(beverage1, 0.10);
            Console.WriteLine("{0} ${1}", beverage1.GetDescription(), beverage1.GetCost());

            Beverage beverage2 = new HouseBlend(0.89, BeverageSize.Grand);
            beverage2 = new Soy(beverage2, 0.15);
            beverage2 = new Mocha(beverage2, 0.20);
            beverage2 = new Whip(beverage2, 0.10);
            Console.WriteLine("{0} ${1}", beverage2.GetDescription(), beverage2.GetCost());

            Console.Read();
        }
    }
}

using System;
namespace Com.HeadFirst.DesignPatterns.Creational.Factory.Sample1
{
    class FactorySample1
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore store = new PizzaStore(factory);

            Pizza pizza = store.OrderPizza("cheese");
            Console.WriteLine("We ordered a {0}", pizza.Name);
            Console.WriteLine(pizza);

            pizza = store.OrderPizza("veggie");
            Console.WriteLine("We ordered a {0}", pizza.Name);
            Console.WriteLine(pizza);

            Console.Read();
        }
    }
}

using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Pizzas;
using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.PizzaStore;
using System;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1
{
    class AbstractFactorySample1
    {
        static void Main(string[] args)
        {
            PizzaStore.PizzaStore nyStore = new NYPizzaStore();
            PizzaStore.PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a {0}", pizza);

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a {0}", pizza);

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a {0}", pizza);

            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered a {0}", pizza);

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a {0}", pizza);

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a {0}", pizza);

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a {0}", pizza);

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a {0}", pizza);

            Console.Read();
        }
    }
}

using System;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample1
{
    class FactoryMethodSample1
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");
            Console.WriteLine("Ethan ordered a {0}", pizza.Name);

            pizza = chicagoStore.OrderPizza("cheese");
            Console.WriteLine("Joel ordered a {0}", pizza.Name);

            pizza = nyStore.OrderPizza("clam");
            Console.WriteLine("Ethan ordered a {0}", pizza.Name);

            pizza = chicagoStore.OrderPizza("clam");
            Console.WriteLine("Joel ordered a {0}", pizza.Name);

            pizza = nyStore.OrderPizza("pepperoni");
            Console.WriteLine("Ethan ordered a {0}", pizza.Name);

            pizza = chicagoStore.OrderPizza("pepperoni");
            Console.WriteLine("Joel ordered a {0}", pizza.Name);

            pizza = nyStore.OrderPizza("veggie");
            Console.WriteLine("Ethan ordered a {0}", pizza.Name);

            pizza = chicagoStore.OrderPizza("veggie");
            Console.WriteLine("Joel ordered a {0}", pizza.Name);

            Console.Read();
        }
    }
}

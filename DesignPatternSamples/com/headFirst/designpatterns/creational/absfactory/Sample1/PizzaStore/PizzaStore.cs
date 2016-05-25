namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.PizzaStore
{
    using Pizzas;
    using System;
    abstract class PizzaStore
    {
        protected abstract Pizza createPizza(string type);

        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;

            pizza = createPizza(type);
            Console.WriteLine("--- Making a " + pizza.Name + " ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}

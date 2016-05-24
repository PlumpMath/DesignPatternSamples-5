using System;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample1
{
    abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza = null;
            pizza = CreatePizza(type);
            Console.WriteLine("--- Making a " + pizza.Name + " ---");
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }
}

using System;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample1
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            var pizzaType = type.ToLower();

            switch (pizzaType)
            {
                case "cheese":
                    pizza = new NYStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new NYStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new NYStyleClamPizza();
                    break;
                case "veggie":
                    pizza = new NYStyleVeggiePizza();
                    break;
            }

            return pizza;
        }
    }
}

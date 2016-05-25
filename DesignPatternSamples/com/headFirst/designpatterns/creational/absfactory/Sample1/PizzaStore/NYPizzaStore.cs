using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Pizzas;
using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.PizzaStore
{
    class NYPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            var ingredientFactory = new NYPizzaIngredientFactory();
            Pizza pizza = null;
            var pizzaType = type.ToLower();

            switch (pizzaType)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "New York Style Cheese Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "New York Style Pepperoni Pizza";
                    break;
                case "clam":
                    pizza = new ClamsPizza(ingredientFactory);
                    pizza.Name = "New York Style Clam Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "New York Style Veggie Pizza";
                    break;
            }

            return pizza;
        }
    }
}

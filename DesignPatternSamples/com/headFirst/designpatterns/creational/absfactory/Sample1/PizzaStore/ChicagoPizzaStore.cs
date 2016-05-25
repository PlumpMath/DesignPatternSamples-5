using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients;
using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Pizzas;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.PizzaStore
{
    class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza createPizza(string type)
        {
            var ingredientFactory = new ChicagoPizzaIngredientFactory();
            Pizza pizza = null;
            var pizzaType = type.ToLower();

            switch (pizzaType)
            {
                case "cheese":
                    pizza = new CheesePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Cheese Pizza";
                    break;
                case "pepperoni":
                    pizza = new PepperoniPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Pepperoni Pizza";
                    break;
                case "clam":
                    pizza = new ClamsPizza(ingredientFactory);
                    pizza.Name = "Chicago Style Clam Pizza";
                    break;
                case "veggie":
                    pizza = new VeggiePizza(ingredientFactory);
                    pizza.Name = "Chicago Style Veggie Pizza";
                    break;
            }

            return pizza;
        }
    }
}

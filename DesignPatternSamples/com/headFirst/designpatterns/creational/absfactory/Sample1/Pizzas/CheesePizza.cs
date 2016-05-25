using System;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Pizzas
{
    using Ingredients;

    class CheesePizza : Pizza
    {
        readonly IPizzaIngredientFactory ingredientFactory;

        public CheesePizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
        }
    }
}

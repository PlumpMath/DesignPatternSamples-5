using System;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Pizzas
{
    using Ingredients;

    class PepperoniPizza : Pizza
    {
        readonly IPizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Veggies = ingredientFactory.CreateVeggies();
            Pepperoni = ingredientFactory.CreatePepperoni();
        }
    }
}

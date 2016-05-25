using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    interface IPizzaIngredientFactory
    {
        Dough CreateDough();

        Cheese CreateCheese();

        Sauce CreateSauce();

        Pepperoni CreatePepperoni();

        IEnumerable<Veggies> CreateVeggies();

        Clams CreateClams();
    }
}

using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public IEnumerable<Veggies> CreateVeggies()
        {
            return new Veggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }
}

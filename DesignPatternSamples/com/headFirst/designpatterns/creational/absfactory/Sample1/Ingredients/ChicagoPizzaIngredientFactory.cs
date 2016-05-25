using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public IEnumerable<Veggies> CreateVeggies()
        {
            return new Veggies[] { new BlackOlives(), new Spinach(), new Eggplant() };
        }
    }
}

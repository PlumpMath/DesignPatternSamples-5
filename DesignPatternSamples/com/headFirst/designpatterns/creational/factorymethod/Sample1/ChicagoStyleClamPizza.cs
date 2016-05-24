using System;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample1
{
    class ChicagoStyleClamPizza : Pizza
    {
        public ChicagoStyleClamPizza() : base()
        {
            Name = "Chicago Style Clam Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Frozen Clams from Chesapeake Bay");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

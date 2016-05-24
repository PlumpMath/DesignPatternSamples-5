using System;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample1
{
    class ChicagoStylePepperoniPizza : Pizza
    {
        public ChicagoStylePepperoniPizza() : base()
        {
            Name = "Chicago Style Pepperoni Pizza";
            Dough = "Extra Thick Crust Dough";
            Sauce = "Plum Tomato Sauce";

            Toppings.Add("Shredded Mozzarella Cheese");
            Toppings.Add("Black Olives");
            Toppings.Add("Spinach");
            Toppings.Add("Eggplant");
            Toppings.Add("Sliced Pepperoni");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}

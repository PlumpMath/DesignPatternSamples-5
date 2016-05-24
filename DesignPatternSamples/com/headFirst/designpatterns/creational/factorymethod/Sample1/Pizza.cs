using System;
using System.Collections.Generic;
using System.Text;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample1
{
    abstract class Pizza
    {
        public string Name { get; protected set; }

        public string Dough { get; protected set; }

        public string Sauce { get; protected set; }

        public IList<string> Toppings { get; private set; }

        protected Pizza()
        {
            Toppings = new List<string>(10);
        }

        public void Prepare()
        {
            Console.WriteLine("Preparing {0}", Name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            foreach (var topping in Toppings)
                Console.WriteLine("\t{0}", topping);
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cut the pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public override string ToString()
        {
            // code to display pizza name and ingredients
            StringBuilder display = new StringBuilder();
            display.AppendLine("---- " + Name + " ----");
            display.AppendLine(Dough);
            display.AppendLine(Sauce);
            foreach (var topping in Toppings)
            {
                display.AppendLine(topping);
            }
            return display.ToString();
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Com.HeadFirst.DesignPatterns.Creational.Factory.Sample1
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
        }

        public void Bake()
        {
            Console.WriteLine("Baking {0}", Name);
        }

        public void Cut()
        {
            Console.WriteLine("Cutting {0}", Name);
        }

        public void Box()
        {
            Console.WriteLine("Boxing {0}", Name);
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

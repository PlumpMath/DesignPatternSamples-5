namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Pizzas
{
    using Ingredients;
    using System;
    using System.Collections.Generic;
    using System.Text;

    abstract class Pizza
    {
        public Dough Dough { get; protected set; }

        public Cheese Cheese { get; protected set; }

        public Sauce Sauce { get; protected set; }

        public Pepperoni Pepperoni { get; protected set; }

        public Clams Clams { get; protected set; }

        public IEnumerable<Veggies> Veggies { get; protected set; }

        public string Name { get; set; }

        public abstract void Prepare();

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
            var result = new StringBuilder();
            result.AppendLine("---- " + Name + " ----");
            if (Dough != null)
                result.AppendLine(Dough.ToString());
            if (Sauce != null)
                result.AppendLine(Sauce.ToString());
            if (Cheese != null)
                result.AppendLine(Cheese.ToString());
            if (Veggies != null)
            {
                bool isFirst = true;
                foreach(var veggy in Veggies)
                {
                    if (isFirst)
                    {
                        result.Append(veggy.ToString());
                        isFirst = false;
                    }
                    else
                    {
                        result.Append(", ");
                        result.Append(veggy.ToString());
                    }
                }
                result.AppendLine();
            }
            if (Pepperoni != null)
                result.AppendLine(Pepperoni.ToString());
            if (Clams != null)
                result.AppendLine(Clams.ToString());
            return result.ToString();
        }
    }
}

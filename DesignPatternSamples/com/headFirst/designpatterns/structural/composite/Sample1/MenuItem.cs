using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample1
{
    class MenuItem : MenuComponent
    {
        public MenuItem(string name, string description, bool vegetarian, double price)
            :base(name, description)
        {
            Vegetarian = vegetarian;
            Price = price;
        }

        public override bool Vegetarian { get; protected set; }

        public override double Price { get; protected set; }

        public override void Print()
        {
            Console.Write(string.Concat(" ", Name));
            if (Vegetarian)
                Console.Write("(v)");
            Console.Write(string.Concat(", ", Price));
            Console.WriteLine(string.Concat("   -- ", Description));
        }
    }
}

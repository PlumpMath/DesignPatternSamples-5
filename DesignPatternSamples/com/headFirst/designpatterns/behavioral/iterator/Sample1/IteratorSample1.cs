using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample1
{
    class IteratorSample1
    {
        static void Main(string[] args)
        {
            PancakeHouseMenu _pancakeHouseMenu = new PancakeHouseMenu();
            DinerMenu _dinerMenu = new DinerMenu();

            Waitress _waitress = new Waitress(_pancakeHouseMenu, _dinerMenu);

            _waitress.PrintMenu();
            _waitress.PrintVegetarianMenu();

            Console.WriteLine("Customer asks, is the Hotdog vegetarian?");
            Console.Write("Waitress says: ");

            if (_waitress.IsVegetarian("Hotdog"))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.WriteLine("Customer asks, are the Waffles vegetarian?");
            Console.Write("Waitress says: ");

            if (_waitress.IsVegetarian("Waffles"))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

            Console.Read();
        }
    }
}

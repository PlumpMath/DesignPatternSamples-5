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
            _waitress.PrintVegeterianMenu();

            Console.Read();
        }
    }
}

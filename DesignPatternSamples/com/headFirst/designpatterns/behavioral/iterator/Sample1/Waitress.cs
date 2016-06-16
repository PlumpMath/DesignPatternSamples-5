using System;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample1
{
    class Waitress
    {
        IEnumerable<MenuItem> _pancakeHouseMenu;
        IEnumerable<MenuItem> _dinerMenu;

        public Waitress(IEnumerable<MenuItem> pancakeHouseMenu, IEnumerable<MenuItem> dinerMenu)
        {
            _pancakeHouseMenu = pancakeHouseMenu;
            _dinerMenu = dinerMenu;
        }

        public void PrintMenu()
        {
            var dinerEnumerator = _dinerMenu.GetEnumerator();
            var pancakeHouseEnumerator = _pancakeHouseMenu.GetEnumerator();

            Console.WriteLine("MENU\r\n----\r\nBREAKFAST");
            printMenu(pancakeHouseEnumerator);
            Console.WriteLine("\r\nLUNCH");
            printMenu(dinerEnumerator);
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\r\nVEGETARIAN MENU\r\n---------------");
            printVegetarianMenu(_pancakeHouseMenu.GetEnumerator());
            printVegetarianMenu(_dinerMenu.GetEnumerator());
        }

        public bool IsVegetarian(string name)
        {
            bool retVal = false;
            if (isVegetarian(name, _pancakeHouseMenu.GetEnumerator()))
                retVal = true;
            else if (isVegetarian(name, _dinerMenu.GetEnumerator()))
                retVal = true;
            return retVal;
        }

        private static void printMenu(IEnumerator<MenuItem> enumerator)
        {
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.Write(string.Concat(item.Name, ","));
                Console.Write(string.Concat(item.Price, " -- "));
                Console.WriteLine(item.Description);
            }
        }

        private static void printVegetarianMenu(IEnumerator<MenuItem> enumerator)
        {
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                if (item.Vegeterian)
                {
                    Console.Write(string.Concat(item.Name, ","));
                    Console.Write(string.Concat(item.Price, " -- "));
                    Console.WriteLine(item.Description);
                }
            }
        }

        private static bool isVegetarian(string name, IEnumerator<MenuItem> enumerator)
        {
            bool retVal = false;
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                if (name.Equals(item.Name) && item.Vegeterian)
                {
                    retVal = true;
                    break;
                }
            }
            return retVal;
        }
    }
}

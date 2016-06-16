﻿using System;
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

        public void PrintVegeterianMenu()
        {
            Console.WriteLine("\r\nVEGETARIAN MENU\r\n---------------");
            printVegeterianMenu(_pancakeHouseMenu.GetEnumerator());
            printVegeterianMenu(_dinerMenu.GetEnumerator());
        }

        private void printMenu(IEnumerator<MenuItem> enumerator)
        {
            while (enumerator.MoveNext())
            {
                var item = enumerator.Current;
                Console.Write(string.Concat(item.Name, ","));
                Console.Write(string.Concat(item.Price, " -- "));
                Console.WriteLine(item.Description);
            }
        }

        private void printVegeterianMenu(IEnumerator<MenuItem> enumerator)
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
    }
}

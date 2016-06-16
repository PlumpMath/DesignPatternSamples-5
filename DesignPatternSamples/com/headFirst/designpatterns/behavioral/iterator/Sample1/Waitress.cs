﻿using System;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample1
{
    class Waitress
    {
        PancakeHouseMenu _pancakeHouseMenu;
        DinerMenu _dinerMenu;

        public Waitress(PancakeHouseMenu pancakeHouseMenu, DinerMenu dinerMenu)
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
    }
}

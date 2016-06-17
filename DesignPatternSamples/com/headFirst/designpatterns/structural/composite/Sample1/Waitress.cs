using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample1
{
    class Waitress
    {
        MenuComponent _allMenus;

        public Waitress(MenuComponent allMenus)
        {
            _allMenus = allMenus;
        }

        public void PrintMenu()
        {
            _allMenus.Print();
        }

        public void PrintVegetarianMenu()
        {
            Console.WriteLine("\r\nVEGETARIAN MENU\r\n----");
            var enumerator = _allMenus.GetEnumerator();

            while(enumerator.MoveNext())
            {
                var menu = enumerator.Current;
                try
                {
                    if (menu.Vegetarian)
                        menu.Print();
                }
                catch (NotSupportedException) { }
            }
        }
    }
}

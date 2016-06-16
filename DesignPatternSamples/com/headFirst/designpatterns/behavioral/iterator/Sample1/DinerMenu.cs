using System;
using System.Collections;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample1
{
    class DinerMenu : IEnumerable<MenuItem>
    {
        readonly int MAX_ITEMS = 6;
        int _noOfItems = 0;
        MenuItem[] _menuItems;

        public DinerMenu()
        {
            _menuItems = new MenuItem[MAX_ITEMS];

            AddItem("Vegetarian BLT", "(Fakin') Bacon with lettuce & tomato on whole wheat", true, 2.99);
            AddItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            AddItem("Soup of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            AddItem("Hotdog", "A hot dog, with saurkraut, relish, onions, topped with cheese", false, 3.05);
            AddItem("Steamed Veggies and Brown Rice", "A medly of steamed vegetables over brown rice", true, 3.99);
            AddItem("Pasta", "Spaghetti with Marinara Sauce, and a slice of sourdough bread", true, 3.89);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var item = new MenuItem(name, description, vegetarian, price);

            if (_noOfItems >= MAX_ITEMS)
                Console.WriteLine("Sorry, menu is full! Can't add item to menu");
            else
            {
                _menuItems[_noOfItems++] = item;
            }
        }

        public MenuItem[] GetMenuItems()
        {
            return _menuItems;
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            for (int i = 0; i < _menuItems.Length; i++)
                yield return _menuItems[i];
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _menuItems.Length; i++)
                yield return _menuItems[i];
        }
    }
}

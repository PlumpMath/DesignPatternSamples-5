using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample1
{
    class PancakeHouseMenu
    {
        ArrayList _menuItems;

        public PancakeHouseMenu()
        {
            _menuItems = new ArrayList();

            AddItem("K&B's Pancake Breakfast", "Pancakes with scrambled eggs, and toast", true, 2.99);

            AddItem("Regular Pancake Breakfast", "Pancakes with fried eggs, sausage", false, 2.99);

            AddItem("Blueberry Pancakes", "Pancakes made with fresh blueberries, and blueberry syrup", true, 3.49);

            AddItem("Waffles", "Waffles, with your choice of blueberries or strawberries", true, 3.59);
        }

        public void AddItem(string name, string description, bool vegeterian, double price)
        {
            var item = new MenuItem(name, description, vegeterian, price);
            _menuItems.Add(item);
        }

        public ArrayList GetMenuItems()
        {
            return _menuItems;
        }
    }
}

using System.Collections;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample1
{
    class PancakeHouseMenu : IEnumerable<MenuItem>
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

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var item = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(item);
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            for (int i = 0; i < _menuItems.Count; i++)
                yield return (MenuItem)_menuItems[i];
        }

        public ArrayList GetMenuItems()
        {
            return _menuItems;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < _menuItems.Count; i++)
                yield return _menuItems[i];
        }
    }
}

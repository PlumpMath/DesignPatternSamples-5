using System.Collections;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample1
{
    class CafeMenu : IEnumerable<MenuItem>
    {
        IDictionary<string, MenuItem> _menuItems;

        public CafeMenu()
        {
            _menuItems = new Dictionary<string, MenuItem>();

            AddItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
            AddItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69);
            AddItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
        }

        public void AddItem(string name, string description, bool vegetarian, double price)
        {
            var item = new MenuItem(name, description, vegetarian, price);
            _menuItems.Add(item.Name, item);
        }

        public IDictionary<string, MenuItem> GetMenuItems()
        {
            return _menuItems;
        }

        public IEnumerator<MenuItem> GetEnumerator()
        {
            return _menuItems.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _menuItems.Values.GetEnumerator();
        }
    }
}

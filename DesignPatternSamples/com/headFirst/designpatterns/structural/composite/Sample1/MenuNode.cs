using System;
using System.Collections;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample1
{
    class MenuNode : MenuComponent
    {
        ArrayList _menuComponents;
        IEnumerator<MenuComponent> _enumerator = null;

        public MenuNode(string name, string description)
            : base(name, description)
        {
            _menuComponents = new ArrayList();
        }

        public override void Add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }

        public override void Remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }

        public override MenuComponent GetChild(int position)
        {
            return (MenuComponent)_menuComponents[position];
        }

        public override void Print()
        {
            Console.Write(string.Concat("\r\n", Name));
            Console.WriteLine(string.Concat(", ", Description));
            Console.WriteLine("---------------------");

            foreach (var component in _menuComponents)
                ((MenuComponent)component).Print();
        }

        public override IEnumerator<MenuComponent> GetEnumerator()
        {
            if (_enumerator == null)
                _enumerator = new CompositeEnumerator((IEnumerator<MenuComponent>)_menuComponents.GetEnumerator());
            return _enumerator;
        }
    }
}

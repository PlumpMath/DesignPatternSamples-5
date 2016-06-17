using System;
using System.Collections;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample1
{
    abstract class MenuComponent : IEnumerable<MenuComponent>
    {
        protected MenuComponent(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public virtual void Add(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual void Remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }

        public virtual MenuComponent GetChild(int position)
        {
            throw new InvalidOperationException();
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public virtual bool Vegetarian { get { throw new InvalidOperationException(); } protected set { } }

        public virtual double Price { get { throw new InvalidOperationException(); } protected set { } }

        public abstract void Print();

        public abstract IEnumerator<MenuComponent> GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}

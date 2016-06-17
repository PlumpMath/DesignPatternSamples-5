using System.Collections;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample1
{
    class NullEnumerator : IEnumerator<MenuComponent>
    {
        public MenuComponent Current
        {
            get
            {
                return null;
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            return false;
        }

        public void Reset() { }
    }
}

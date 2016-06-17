using System;
using System.Collections;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample1
{
    class CompositeEnumerator : IEnumerator<MenuComponent>
    {
        Stack<IEnumerator<MenuComponent>> _enumeratorStack;

        public CompositeEnumerator(IEnumerator<MenuComponent> enumerator)
        {
            _enumeratorStack.Push(enumerator);
        }

        public MenuComponent Current
        {
            get
            {
                if (MoveNext())
                {
                    var enumerator = _enumeratorStack.Peek();
                    var component = enumerator.Current;
                    _enumeratorStack.Push(component.GetEnumerator());
                    return component;
                }
                else
                {
                    return null;
                }
            }
        }

        object IEnumerator.Current
        {
            get
            {
                return this.Current;
            }
        }

        public void Dispose()
        {
            _enumeratorStack = null;
        }

        public bool MoveNext()
        {
            if (_enumeratorStack.Count == 0)
                return false;
            else
            {
                var component = _enumeratorStack.Peek();
                if (!component.MoveNext())
                {
                    _enumeratorStack.Pop();
                    return MoveNext();
                }
                else
                {
                    return true;
                }
            }
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
}

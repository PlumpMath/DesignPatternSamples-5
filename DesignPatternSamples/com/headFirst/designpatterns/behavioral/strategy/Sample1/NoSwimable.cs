using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Strategy.Sample1
{
    class NoSwimable : ISwimable
    {
        private string _name;

        public NoSwimable(string name)
        {
            _name = name;
        }

        public bool CanSwim
        {
            get
            {
                return false;
            }
        }

        public void Swim()
        {
            Console.WriteLine("{0} can't swim.", _name);
        }
    }
}

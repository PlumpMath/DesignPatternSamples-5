using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Strategy.Sample1
{
    class NoFlyable : IFlyable
    {
        private string _name;

        public NoFlyable(string name)
        {
            _name = name;
        }

        public bool CanFly
        {
            get
            {
                return false;
            }
        }

        public void Fly()
        {
            Console.WriteLine("{0} can't fly.", _name);
        }
    }
}

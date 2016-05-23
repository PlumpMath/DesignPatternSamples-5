using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Strategy.Sample1
{
    class Flyable : IFlyable
    {
        private string _name;

        public Flyable(string name)
        {
            _name = name;
        }

        public bool CanFly
        {
            get
            {
                return true;
            }
        }

        public void Fly()
        {
            Console.WriteLine("{0} can fly.", _name);
        }
    }
}

using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class PopcornPopper
    {
        private string _description;

        public PopcornPopper(string description)
        {
            _description = description;
        }

        public void On()
        {
            Console.WriteLine("{0} on", _description);
        }

        public void Off()
        {
            Console.WriteLine("{0} off", _description);
        }

        public void Pop()
        {
            Console.WriteLine("{0} popping popcorn!", _description);
        }

        public override string ToString()
        {
            return _description;
        }
    }
}

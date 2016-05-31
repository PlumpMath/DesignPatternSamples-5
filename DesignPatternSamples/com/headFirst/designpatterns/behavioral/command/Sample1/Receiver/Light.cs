using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver
{
    class Light
    {
        readonly string _location;
        int _level;

        public Light(string location)
        {
            _location = location;
        }

        public void On()
        {
            _level = 100;
            Console.WriteLine("{0} light is on", _location);
        }

        public void Off()
        {
            _level = 0;
            Console.WriteLine("{0} light is off", _location);
        }

        public void Dim(int level)
        {
            _level = level;
            if (_level == 0)
            {
                Off();
            }
            else
            {
                Console.WriteLine("{1} light is dimmed to {0}%", _level, _location);
            }
        }

        public int Level { get { return _level; } }
    }
}

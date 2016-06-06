using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class TheaterLights
    {
        private string _description;

        public TheaterLights(string description)
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

        public void Dim(int level)
        {
            Console.WriteLine("{0} dimming to {1}%", _description, level);
        }

        public override string ToString()
        {
            return _description;
        }
    }
}

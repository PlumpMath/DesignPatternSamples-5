using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver
{
    class TV
    {
        readonly string _location;

        public TV(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine("{0} TV is on", _location);
        }

        public void Off()
        {
            Console.WriteLine("{0} TV is off", _location);
        }

        public void SetInputChannel()
        {
            Console.WriteLine("{0} TV channel is set for DVD", _location);
        }
    }
}

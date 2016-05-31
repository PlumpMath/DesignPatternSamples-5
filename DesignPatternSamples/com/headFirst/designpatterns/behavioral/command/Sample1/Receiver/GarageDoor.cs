using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver
{
    class GarageDoor
    {
        readonly string _location;

        public GarageDoor(string location)
        {
            _location = location;
        }

        public void Up()
        {
            Console.WriteLine("{0} garage door is up", _location);
        }

        public void Down()
        {
            Console.WriteLine("{0} garage door is down", _location);
        }

        public void LightOn()
        {
            Console.WriteLine("{0} garage light is on", _location);
        }

        public void LightOff()
        {
            Console.WriteLine("{0} garage light is off", _location);
        }
    }
}

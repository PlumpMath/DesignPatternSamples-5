using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver
{
    class CeilingFan
    {
        public enum CeilingFanSpeed { Off = 0, Low, Medium, High };

        readonly string _location;

        CeilingFanSpeed _speed = CeilingFanSpeed.Off;

        public CeilingFan(string location)
        {
            _location = location;
        }

        public void SetHighSpeed()
        {
            _speed = CeilingFanSpeed.High;
            Console.WriteLine("{0} ceiling fan is on high", _location);
        }

        public void SetMediumSpeed()
        {
            _speed = CeilingFanSpeed.Medium;
            Console.WriteLine("{0} ceiling fan is on medium", _location);
        }

        public void SetLowSpeed()
        {
            _speed = CeilingFanSpeed.Low;
            Console.WriteLine("{0} ceiling fan is on low", _location);
        }

        public void SetOff()
        {
            _speed = CeilingFanSpeed.Off;
            Console.WriteLine("{0} ceiling fan is off", _location);
        }

        public CeilingFanSpeed Speed { get { return _speed; } }
    }
}

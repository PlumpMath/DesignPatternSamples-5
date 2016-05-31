using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver
{
    class Stereo
    {
        readonly string _location;

        public Stereo(string location)
        {
            _location = location;
        }

        public void On()
        {
            Console.WriteLine("{0} stereo is on", _location);
        }

        public void Off()
        {
            Console.WriteLine("{0} stereo is off", _location);
        }

        public void SetCD()
        {
            Console.WriteLine("{0} stereo is set for CD input", _location);
        }

        public void SetDVD()
        {
            Console.WriteLine("{0} stereo is set for DVD input", _location);
        }

        public void SetRadio()
        {
            Console.WriteLine("{0} stereo is set for Radio", _location);
        }

        public void SetVolume(int volume)
        {
            Console.WriteLine("{0} Stereo volume set to {1}", _location, volume);
        }
    }
}

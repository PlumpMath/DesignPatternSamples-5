using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class Projector
    {
        string _description;
        DvdPlayer _dvdPlayer;

        public Projector(string description, DvdPlayer dvdPlayer)
        {
            _description = description;
            _dvdPlayer = dvdPlayer;
        }

        public void On()
        {
            Console.WriteLine("{0} on", _description);
        }

        public void Off()
        {
            Console.WriteLine("{0} off", _description);
        }

        public void WideScreenMode()
        {
            Console.WriteLine("{0} in widescreen mode (16X9 aspect ratio)", _description);
        }

        public void TvMode()
        {
            Console.WriteLine("{0} in tv mode (4X3 aspect ratio)", _description);
        }

        public override string ToString()
        {
            return _description;
        }
    }
}

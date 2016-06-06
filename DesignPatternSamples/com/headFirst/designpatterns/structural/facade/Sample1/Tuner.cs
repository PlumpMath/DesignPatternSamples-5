using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class Tuner
    {
        string _description;
        double _frequency;
        private Amplifier _amplifier;

        public Tuner(string description, Amplifier amplifier)
        {
            _description = description;
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("{0} on", _description);
        }

        public void Off()
        {
            Console.WriteLine("{0} off", _description);
        }

        public void SetFrequency(double frequency)
        {
            Console.WriteLine("{0} setting frequency to {1}", _description, frequency);
            _frequency = frequency;
        }

        public void SetAM()
        {
            Console.WriteLine("{0} setting AM mode", _description);
        }

        public void SetFM()
        {
            Console.WriteLine("{0} setting FM mode", _description);
        }

        public override string ToString()
        {
            return _description;
        }
    }
}

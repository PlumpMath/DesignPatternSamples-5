using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Command.Sample1.Receiver
{
    class Hottub
    {
        bool _on;
        int _temperature;

        public void On()
        {
            _on = true;
        }

        public void Off()
        {
            _on = false;
        }

        public void Circulate()
        {
            if (_on)
            {
                Console.WriteLine("Hottub is bubbling!");
            }
        }

        public void JetsOn()
        {
            if (_on)
            {
                Console.WriteLine("Hottub jets are on");
            }
        }

        public void JetsOff()
        {
            if (_on)
            {
                Console.WriteLine("Hottub jets are off");
            }
        }

        public void setTemperature(int temperature)
        {
            if (temperature > _temperature)
            {
                Console.WriteLine("Hottub is heating to a steaming {0} degrees", _temperature);
            }
            else
            {
                Console.WriteLine("Hottub is cooling to {0} degrees", _temperature);
            }
            _temperature = temperature;
        }
    }
}

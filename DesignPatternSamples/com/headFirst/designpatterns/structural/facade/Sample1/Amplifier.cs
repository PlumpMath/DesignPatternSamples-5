using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class Amplifier
    {
        string _description;
        Tuner tuner;
        DvdPlayer dvd;
        CdPlayer cd;

        public Amplifier(string description)
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

        public void SetStereoSound()
        {
            Console.WriteLine("{0} stereo mode on", _description);
        }

        public void SetSurroundSound()
        {
            Console.WriteLine("{0} surround sound on (5 speakers, 1 subwoofer)", _description);
        }

        public void SetVolume(int level)
        {
            Console.WriteLine("{0} setting volume to {1}", _description, level);
        }

        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine("{0} setting tuner to {1}", _description, dvd);
            this.tuner = tuner;
        }

        public void SetDvd(DvdPlayer dvd)
        {
            Console.WriteLine("{0} setting DVD player to {1}", _description, dvd);
            this.dvd = dvd;
        }

        public void SetCd(CdPlayer cd)
        {
            Console.WriteLine("{0} setting CD player to {1}", _description, cd);
            this.cd = cd;
        }

        public override string ToString()
        {
            return _description;
        }
    }
}

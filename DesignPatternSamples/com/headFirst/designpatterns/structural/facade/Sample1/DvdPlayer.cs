using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class DvdPlayer
    {
        private string _description;
        private int _currentTrack;
        private string _movie;
        private Amplifier _amplifier;

        public DvdPlayer(string description, Amplifier amplifier)
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

        public void Eject()
        {
            _movie = string.Empty;
            Console.WriteLine("{0} eject", _description);
        }

        public void Play(string movie)
        {
            _movie = movie;
            _currentTrack = 0;
            Console.WriteLine("{0} playing \"{1}\"", _description, _movie);
        }

        public void Play(int track)
        {
            if (string.IsNullOrEmpty(_movie))
                Console.WriteLine("{0} can't play track {1} no dvd inserted", _description, track);
            else
            {
                _currentTrack = track;
                Console.WriteLine("{0} playing track {1} of movie \"{2}\"", _description, _currentTrack, _movie);
            }
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine("{0} stopped \"{1}\"", _description, _movie);
        }

        public void Pause()
        {
            Console.WriteLine("{0} paused \"{1}\"", _description, _movie);
        }

        public void SetTwoChannelAudio()
        {
            Console.WriteLine("{0} set two channel audio", _description);
        }

        public void SetSurroundAudio()
        {
            Console.WriteLine("{0} set surround audio", _description);
        }

        public override string ToString()
        {
            return _description;
        }
    }
}

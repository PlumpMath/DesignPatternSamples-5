using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class CdPlayer
    {
        private string _description;
        private int _currentTrack;
        private string _title;
        private Amplifier _amplifier;

        public CdPlayer(string description, Amplifier amplifier)
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
            _title = string.Empty;
            Console.WriteLine("{0} eject", _description);
        }

        public void Play(string title)
        {
            _title = title;
            _currentTrack = 0;
            Console.WriteLine("{0} playing \"{1}\"", _description, _title);
        }

        public void Play(int track)
        {
            if (string.IsNullOrEmpty(_title))
                Console.WriteLine("{0} can't play track {1}, no cd inserted", _description, track);
            else
            {
                _currentTrack = track;
                Console.WriteLine("{0} playing track {1} of movie \"{2}\"", _description, _currentTrack, _title);
            }
        }

        public void Stop()
        {
            _currentTrack = 0;
            Console.WriteLine("{0} stopped", _description);
        }

        public void Pause()
        {
            Console.WriteLine("{0} paused \"{1}\"", _description, _title);
        }

        public override string ToString()
        {
            return _description;
        }
    }
}

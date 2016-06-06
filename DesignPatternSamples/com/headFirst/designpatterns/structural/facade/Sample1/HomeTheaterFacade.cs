using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class HomeTheaterFacade
    {
        Amplifier _amplifier;
        CdPlayer _cdPlayer;
        DvdPlayer _dvdPlayer;
        PopcornPopper _popcornPopper;
        Projector _projector;
        Screen _screen;
        TheaterLights _theaterLights;
        Tuner _tuner;

        public HomeTheaterFacade(Amplifier amplifier, CdPlayer cdPlayer, DvdPlayer dvdPlayer, PopcornPopper popcornPopper, Projector projector, Screen screen, TheaterLights theaterLights, Tuner tuner)
        {
            _amplifier = amplifier;
            _cdPlayer = cdPlayer;
            _dvdPlayer = dvdPlayer;
            _popcornPopper = popcornPopper;
            _projector = projector;
            _screen = screen;
            _theaterLights = theaterLights;
            _tuner = tuner;
        }

        public void WatchMovie(string movie)
        {
            Console.WriteLine("Get ready to watch movie...");
            _popcornPopper.On();
            _popcornPopper.Pop();
            _theaterLights.Dim(10);
            _screen.Down();
            _projector.On();
            _projector.WideScreenMode();
            _amplifier.On();
            _amplifier.SetDvd(_dvdPlayer);
            _amplifier.SetSurroundSound();
            _amplifier.SetVolume(5);
            _dvdPlayer.On();
            _dvdPlayer.Play(movie);
        }

        public void EndMovie()
        {
            Console.WriteLine("Shutting movie theater down...");
            _popcornPopper.Off();
            _theaterLights.On();
            _screen.Up();
            _projector.Off();
            _amplifier.Off();
            _dvdPlayer.Stop();
            _dvdPlayer.Eject();
            _dvdPlayer.Off();
        }

        public void ListenToCd(string cdTitle)
        {
            Console.WriteLine("Get ready for an audiopile experence...");
            _theaterLights.On();
            _amplifier.On();
            _amplifier.SetVolume(5);
            _amplifier.SetCd(_cdPlayer);
            _amplifier.SetStereoSound();
            _cdPlayer.On();
            _cdPlayer.Play(cdTitle);
        }

        public void EndCd()
        {
            Console.WriteLine("Shutting down CD...");
            _amplifier.Off();
            _cdPlayer.Stop();
            _cdPlayer.Eject();
            _cdPlayer.Off();
        }

        public void ListenToRadio(double frequency)
        {
            Console.WriteLine("Tuning in the airwaves...");
            _tuner.On();
            _tuner.SetFrequency(frequency);
            _amplifier.On();
            _amplifier.SetVolume(5);
            _amplifier.SetTuner(_tuner);
        }

        public void EndRadio()
        {
            _tuner.Off();
            _amplifier.Off();
        }
    }
}

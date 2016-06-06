using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Facade.Sample1
{
    class FacadeSample1
    {
        static void Main(string[] args)
        {
            Amplifier amp = new Amplifier("Top-O-Line Amplifier");
            Tuner tuner = new Tuner("Top-O-Line AM/FM Tuner", amp);
            DvdPlayer dvd = new DvdPlayer("Top-O-Line DVD Player", amp);
            CdPlayer cd = new CdPlayer("Top-O-Line CD Player", amp);
            Projector projector = new Projector("Top-O-Line Projector", dvd);
            TheaterLights lights = new TheaterLights("Theater Ceiling Lights");
            Screen screen = new Screen("Theater Screen");
            PopcornPopper popper = new PopcornPopper("Popcorn Popper");

            HomeTheaterFacade homeTheater =
                    new HomeTheaterFacade(amp, cd, dvd, popper,
                            projector, screen, lights, tuner);

            homeTheater.WatchMovie("Raiders of the Lost Ark");
            homeTheater.EndMovie();
            Console.Read();
        }
    }
}

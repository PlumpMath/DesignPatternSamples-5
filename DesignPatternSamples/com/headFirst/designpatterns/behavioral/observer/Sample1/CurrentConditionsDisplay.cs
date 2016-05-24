using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample1
{
    class CurrentConditionsDisplay : IObserver
    {
        private readonly IObservable _observable;

        public CurrentConditionsDisplay(IObservable observable)
        {
            _observable = observable;
            _observable.AddObserver(this);
        }

        public void Update(WeatherObject wobject)
        {
            Console.WriteLine("Current conditions: {0}F degrees and {1}% humility", wobject.Temperature, wobject.Humility);
        }
    }
}

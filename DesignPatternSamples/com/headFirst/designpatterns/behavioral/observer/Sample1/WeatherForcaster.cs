using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample1
{
    class WeatherForcaster : IObservable
    {
        private readonly IList<IObserver> _observers;
        private WeatherObject _weatherObject;

        public WeatherForcaster()
        {
            _observers = new List<IObserver>(5);
        }

        public void AddObserver(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void SetWeatherMeasurement(WeatherObject wobject)
        {
            _weatherObject = wobject;
            NotifyAll();
        }

        public void NotifyAll()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_weatherObject);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}

using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample1
{
    class StatisticDisplay : IObserver, IDisposable
    {
        private readonly IObservable _observable;
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;

        public StatisticDisplay(IObservable observable)
        {
            _observable = observable;
            _observable.AddObserver(this);
        }

        public void Update(WeatherObject wobject)
        {
            tempSum += wobject.Temperature;
            numReadings++;

            if (wobject.Temperature > maxTemp)
                maxTemp = wobject.Temperature;
            if (wobject.Temperature < minTemp)
                minTemp = wobject.Temperature;

            Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2}", (tempSum/numReadings), maxTemp, minTemp);
        }

        private void unregister()
        {
            _observable.RemoveObserver(this);
        }

        public void Dispose()
        {
            unregister();
        }

        ~StatisticDisplay()
        {
            unregister();
        }
    }
}

using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample1
{
    class ForcastDisplay : IObserver
    {
        private readonly IObservable _observable;
        private float currentPressure = 29.92f;
        private float lastPressure;

        public ForcastDisplay(IObservable observable)
        {
            _observable = observable;
            _observable.AddObserver(this);
        }

        public void Update(WeatherObject wobject)
        {
            lastPressure = currentPressure;
            currentPressure = wobject.Presure;

            Console.Write("Forcast: ");

            if (currentPressure > lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("More of the same");
            else
                Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}

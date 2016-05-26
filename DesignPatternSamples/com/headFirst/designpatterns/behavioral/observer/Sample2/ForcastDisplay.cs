using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample2
{
    class ForcastDisplay : IDisposable
    {
        readonly WeatherForcaster weatherForcaster;
        private float currentPressure = 29.92f;
        private float lastPressure;

        public ForcastDisplay(WeatherForcaster weatherForcaster)
        {
            this.weatherForcaster = weatherForcaster;
            weatherForcaster.WeatherObjectChanged += new WeatherForcaster.WeatherObjectChangedEventHandler(Update);
        }

        private void Update(object sender, EventArgs e)
        {
            lastPressure = currentPressure;
            if (sender is WeatherForcaster)
            {
                var wobject = ((WeatherForcaster)sender).WeatherReading;
                currentPressure = wobject.Presure;
            }

            Console.Write("Forcast: ");

            if (currentPressure > lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("More of the same");
            else
                Console.WriteLine("Watch out for cooler, rainy weather");
        }

        private void unregister()
        {
            weatherForcaster.WeatherObjectChanged -= new WeatherForcaster.WeatherObjectChangedEventHandler(Update);
        }

        public void Dispose()
        {
            unregister();
        }

        ~ForcastDisplay()
        {
            unregister();
        }
    }
}

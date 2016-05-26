using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample2
{
    class CurrentConditionsDisplay : IDisposable
    {
        readonly WeatherForcaster weatherForcaster;

        public CurrentConditionsDisplay(WeatherForcaster weatherForcaster)
        {
            this.weatherForcaster = weatherForcaster;
            weatherForcaster.WeatherObjectChanged += new WeatherForcaster.WeatherObjectChangedEventHandler(Update);
        }

        private void Update(object sender, EventArgs e)
        {
            if(sender is WeatherForcaster)
            {
                var wobject = ((WeatherForcaster)sender).WeatherReading;
                Console.WriteLine("Current conditions: {0}F degrees and {1}% humility", wobject.Temperature, wobject.Humility);
            }
        }

        private void unregister()
        {
            weatherForcaster.WeatherObjectChanged -= new WeatherForcaster.WeatherObjectChangedEventHandler(Update);
        }

        public void Dispose()
        {
            unregister();
        }

        ~CurrentConditionsDisplay()
        {
            unregister();
        }
    }
}

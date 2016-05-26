using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample2
{
    class StatisticDisplay : IDisposable
    {
        readonly WeatherForcaster weatherForcaster;
        private float maxTemp = 0.0f;
        private float minTemp = 200;
        private float tempSum = 0.0f;
        private int numReadings;

        public StatisticDisplay(WeatherForcaster weatherForcaster)
        {
            this.weatherForcaster = weatherForcaster;
            weatherForcaster.WeatherObjectChanged += new WeatherForcaster.WeatherObjectChangedEventHandler(Update);
        }

        private void Update(object sender, EventArgs e)
        {
            if (sender is WeatherForcaster)
            {
                var wobject = ((WeatherForcaster)sender).WeatherReading;
                tempSum += wobject.Temperature;
                numReadings++;

                if (wobject.Temperature > maxTemp)
                    maxTemp = wobject.Temperature;
                if (wobject.Temperature < minTemp)
                    minTemp = wobject.Temperature;

                Console.WriteLine("Avg/Max/Min temperature = {0}/{1}/{2}", (tempSum / numReadings), maxTemp, minTemp);
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

        ~StatisticDisplay()
        {
            unregister();
        }
    }
}

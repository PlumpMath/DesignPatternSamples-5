using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample2
{
    class ObserverSample2
    {
        static void Main(string[] args)
        {
            WeatherForcaster weatherForcaster = new WeatherForcaster();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherForcaster);
            StatisticDisplay statisticDisplay = new StatisticDisplay(weatherForcaster);
            ForcastDisplay forcastDisplay = new ForcastDisplay(weatherForcaster);

            weatherForcaster.SetWeatherMeasurement(new WeatherObject(80, 65, 30.4f));
            weatherForcaster.SetWeatherMeasurement(new WeatherObject(82, 70, 29.2f));
            weatherForcaster.SetWeatherMeasurement(new WeatherObject(78, 90, 29.2f));

            currentDisplay.Dispose();
            statisticDisplay.Dispose();

            HeatIndexDisplay heatIndexDisplay = new HeatIndexDisplay(weatherForcaster);

            weatherForcaster.SetWeatherMeasurement(new WeatherObject(80, 65, 30.4f));
            weatherForcaster.SetWeatherMeasurement(new WeatherObject(82, 70, 29.2f));
            weatherForcaster.SetWeatherMeasurement(new WeatherObject(78, 90, 29.2f));

            Console.Read();
        }
    }
}

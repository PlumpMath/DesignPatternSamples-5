﻿using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample2
{
    class HeatIndexDisplay : IDisposable
    {
        readonly WeatherForcaster weatherForcaster;

        public HeatIndexDisplay(WeatherForcaster weatherForcaster)
        {
            this.weatherForcaster = weatherForcaster;
            weatherForcaster.WeatherObjectChanged += new WeatherForcaster.WeatherObjectChangedEventHandler(Update);
        }

        private void Update(object sender, EventArgs e)
        {
            if (sender is WeatherForcaster)
            {
                var wobject = ((WeatherForcaster)sender).WeatherReading;
                Console.WriteLine("Heat Index is {0}", computeHeatIndex(wobject.Temperature, wobject.Humility));
            }
        }

        private float computeHeatIndex(float t, float rh)
        {
            float index = (float)((16.923 + (0.185212 * t) + (5.37941 * rh) - (0.100254 * t * rh)
                + (0.00941695 * (t * t)) + (0.00728898 * (rh * rh))
                + (0.000345372 * (t * t * rh)) - (0.000814971 * (t * rh * rh)) +
                (0.0000102102 * (t * t * rh * rh)) - (0.000038646 * (t * t * t)) + (0.0000291583 *
                (rh * rh * rh)) + (0.00000142721 * (t * t * t * rh)) +
                (0.000000197483 * (t * rh * rh * rh)) - (0.0000000218429 * (t * t * t * rh * rh)) +
                0.000000000843296 * (t * t * rh * rh * rh)) -
                (0.0000000000481975 * (t * t * t * rh * rh * rh)));
            return index;
        }

        private void unregister()
        {
            weatherForcaster.WeatherObjectChanged -= new WeatherForcaster.WeatherObjectChangedEventHandler(Update);
        }

        public void Dispose()
        {
            unregister();
        }

        ~HeatIndexDisplay()
        {
            unregister();
        }
    }
}

using System;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample2
{
    class WeatherForcaster
    {
        public WeatherObject WeatherReading { get; private set; }

        public delegate void WeatherObjectChangedEventHandler(object sender, EventArgs arg);

        public event WeatherObjectChangedEventHandler WeatherObjectChanged;

        public void SetWeatherMeasurement(WeatherObject wobject)
        {
            WeatherReading = wobject;
            onWeatherObjectChanged();
        }

        private void onWeatherObjectChanged()
        {
            if (WeatherObjectChanged != null)
                WeatherObjectChanged(this, new EventArgs());
        }
    }
}

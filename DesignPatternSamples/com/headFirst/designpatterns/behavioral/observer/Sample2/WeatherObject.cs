namespace Com.HeadFirst.DesignPatterns.Behavioral.Observer.Sample2
{
    class WeatherObject
    {
        public WeatherObject(float temperature, float humility, float presure)
        {
            Temperature = temperature;
            Humility = humility;
            Presure = presure;
        }

        public float Temperature { get; private set; }

        public float Humility { get; private set; }

        public float Presure { get; private set; }
    }
}

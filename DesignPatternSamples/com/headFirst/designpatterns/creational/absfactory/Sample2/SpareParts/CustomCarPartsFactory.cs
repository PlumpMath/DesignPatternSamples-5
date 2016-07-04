namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    class CustomCarPartsFactory : ICarPartsFactory
    {
        Wheel _wheel;
        Engine _engine;
        Transmission _transmission;
        Window _window;
        EngineStarter _starter;

        public CustomCarPartsFactory(Wheel wheel, Engine engine, Transmission transmission, Window window, EngineStarter starter)
        {
            _wheel = wheel;
            _engine = engine;
            _transmission = transmission;
            _window = window;
            _starter = starter;
        }

        public Engine GetEngine()
        {
            return _engine;
        }

        public EngineStarter GetStarter()
        {
            return _starter;
        }

        public Transmission GetTransmission()
        {
            return _transmission;
        }

        public Wheel GetWheel()
        {
            return _wheel;
        }

        public Window GetWindow()
        {
            return _window;
        }
    }
}

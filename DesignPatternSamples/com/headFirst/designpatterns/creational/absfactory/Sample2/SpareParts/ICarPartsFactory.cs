namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    interface ICarPartsFactory
    {
        Wheel CreateWheel();

        Engine CreateEngine();

        Transmission CreateTransmission();

        Window CreateWindow();

        EngineStarter CreateStarter();
    }
}

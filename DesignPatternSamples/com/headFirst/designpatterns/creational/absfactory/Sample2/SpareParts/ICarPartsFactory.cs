namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    interface ICarPartsFactory
    {
        Wheel GetWheel();

        Engine GetEngine();

        Transmission GetTransmission();

        Window GetWindow();

        EngineStarter GetStarter();
    }
}

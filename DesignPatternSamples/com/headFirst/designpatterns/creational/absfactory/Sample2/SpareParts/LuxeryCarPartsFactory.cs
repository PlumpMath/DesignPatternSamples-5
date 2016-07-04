namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    class LuxeryCarPartsFactory : CustomCarPartsFactory
    {
        public LuxeryCarPartsFactory()
            : base(new AlloyWheel(), new PetrolEngine(), new AutoTransmission(), new PowerWindow(), new AutoEngineStarter())
        { }
    }
}

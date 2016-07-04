namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    class SedenCarPartsFactory : CustomCarPartsFactory
    {
        public SedenCarPartsFactory()
            : base(new AlloyWheel(), new PetrolEngine(), new ManualTransmission(), new ManualWindow(), new KeyEngineStarter())
        { }
    }
}

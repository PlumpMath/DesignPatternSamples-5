namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    class HatchbackCarPartsFactory : CustomCarPartsFactory
    {
        public HatchbackCarPartsFactory()
            : base(new CustomWheel(), new PetrolEngine(), new ManualTransmission(), new ManualWindow(), new KeyEngineStarter())
        { }
    }
}

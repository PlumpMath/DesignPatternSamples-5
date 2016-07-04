using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Cars
{
    class SedenCar : Car
    {
        public SedenCar()
        {
            carpartFactory = new SedenCarPartsFactory();
        }

        public SedenCar(ICarPartsFactory carpartFactory)
        {
            this.carpartFactory = carpartFactory;
        }
    }
}

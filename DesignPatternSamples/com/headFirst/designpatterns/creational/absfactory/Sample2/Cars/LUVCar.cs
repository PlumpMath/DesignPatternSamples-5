using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Cars
{
    class LUVCar : Car
    {
        public LUVCar()
        {
            carpartFactory = new LuxeryCarPartsFactory();
        }

        public LUVCar(ICarPartsFactory carpartFactory)
        {
            this.carpartFactory = carpartFactory;
        }
    }
}

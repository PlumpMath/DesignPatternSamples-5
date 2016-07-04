using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Cars
{
    class SUVCar : Car
    {
        public SUVCar()
        {
            carpartFactory = new LuxeryCarPartsFactory();
        }

        public SUVCar(ICarPartsFactory carpartFactory)
        {
            this.carpartFactory = carpartFactory;
        }
    }
}

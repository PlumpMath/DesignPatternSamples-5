﻿using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Cars
{
    class HatchbackCar : Car
    {
        public HatchbackCar()
        {
            carpartFactory = new HatchbackCarPartsFactory();
        }

        public HatchbackCar(ICarPartsFactory carpartFactory)
        {
            this.carpartFactory = carpartFactory;
        }
    }
}

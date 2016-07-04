using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Cars;
using System;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Manufecture
{
    abstract class CarFactory
    {
        protected abstract Car ProduceCar(string type);

        public Car DeliverCar(string type)
        {
            var car = ProduceCar(type);
            car.AssembleCar();
            Console.WriteLine("Delivering {0}", car.ModelName);
            return car;
        }
    }
}

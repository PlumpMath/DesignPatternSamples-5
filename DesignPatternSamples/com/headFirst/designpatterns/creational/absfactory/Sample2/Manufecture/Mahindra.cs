using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Cars;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Manufecture
{
    class Mahindra : CarFactory
    {
        protected override Car ProduceCar(string type)
        {
            Car car = null;
            var carType = type.ToLower();

            switch (carType)
            {
                case "hatchback":
                    car = new HatchbackCar();
                    car.ModelName = "Mahindra's hatch back car.";
                    break;
                case "seden":
                    car = new SedenCar();
                    car.ModelName = "Mahindra's seden car.";
                    break;
                case "suv":
                    car = new SUVCar();
                    car.ModelName = "Mahindra's SUV car.";
                    break;
                case "luv":
                    car = new LUVCar();
                    car.ModelName = "Mahindra's LUV car.";
                    break;
            }

            return car;
        }
    }
}

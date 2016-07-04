using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Manufecture;
using System;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2
{
    class AbstractFactorySample2
    {
        static void Main(string[] args)
        {
            CarFactory manufacture = new TataMotors();

            var car = manufacture.DeliverCar("seden");
            Console.WriteLine("Introducing {0}", car.ModelName);
            Console.WriteLine(car);

            car = manufacture.DeliverCar("luv");
            Console.WriteLine("Introducing {0}", car.ModelName);
            Console.WriteLine(car);

            manufacture = new Mahindra();
            car = manufacture.DeliverCar("suv");
            Console.WriteLine("Introducing {0}", car.ModelName);
            Console.WriteLine(car);
            Console.Read();
        }
    }
}

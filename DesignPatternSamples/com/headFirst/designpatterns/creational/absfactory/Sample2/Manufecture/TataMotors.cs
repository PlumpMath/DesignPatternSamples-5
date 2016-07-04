using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Cars;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Manufecture
{
    class TataMotors : CarFactory
    {
        protected override Car ProduceCar(string type)
        {
            Car car = null;
            var carType = type.ToLower();

            switch (carType)
            {
                case "hatchback":
                    car = new HatchbackCar();
                    car.ModelName = "Tata motors hatch back car.";
                    break;
                case "seden":
                    car = new SedenCar();
                    car.ModelName = "Tata motors seden car.";
                    break;
                case "suv":
                    car = new SUVCar();
                    car.ModelName = "Tata motors SUV car.";
                    break;
                case "luv":
                    car = new LUVCar();
                    car.ModelName = "Tata motors LUV car.";
                    break;
            }

            return car;
        }
    }
}

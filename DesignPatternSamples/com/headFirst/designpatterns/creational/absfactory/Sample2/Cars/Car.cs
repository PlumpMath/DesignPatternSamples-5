using Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts;
using System;
using System.Text;

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.Cars
{
    abstract class Car
    {
        protected ICarPartsFactory carpartFactory;

        public Wheel Wheel { get; set; }

        public Engine Engine { get; set; }

        public Transmission Transmission { get; set; }

        public Window Window { get; set; }

        public EngineStarter Starter { get; set; }

        public string ModelName { get; set; }

        public virtual void AssembleCar()
        {
            Console.WriteLine("Assembling {0} car", ModelName);

            Wheel = carpartFactory.GetWheel();
            Engine = carpartFactory.GetEngine();
            Transmission = carpartFactory.GetTransmission();
            Window = carpartFactory.GetWindow();
            Starter = carpartFactory.GetStarter();
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendFormat("Specification for {0}\r\n", ModelName);
            if (Wheel != null)
                builder.AppendLine(Wheel.ToString());
            if (Engine != null)
                builder.AppendLine(Engine.ToString());
            if (Transmission != null)
                builder.AppendLine(Transmission.ToString());
            if (Window != null)
                builder.AppendLine(Window.ToString());
            if (Starter != null)
                builder.AppendLine(Starter.ToString());
            return base.ToString();
        }
    }
}

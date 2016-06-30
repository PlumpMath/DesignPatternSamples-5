namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    abstract class Engine
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class PetrolEngine : Engine
    {
        protected override string getString()
        {
            return "Petrol Engine";
        }
    }

    class DieselEngine : Engine
    {
        protected override string getString()
        {
            return "Diesel Engine";
        }
    }
}

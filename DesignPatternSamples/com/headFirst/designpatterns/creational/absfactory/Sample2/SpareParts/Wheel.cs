namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample2.SpareParts
{
    abstract class Wheel
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class AlloyWheel : Wheel
    {
        protected override string getString()
        {
            return "Alloy Wheel";
        }
    }

    class CustomWheel : Wheel
    {
        protected override string getString()
        {
            return "Custom Wheel";
        }
    }
}

namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    abstract class Pepperoni
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class SlicedPepperoni : Pepperoni
    {
        protected override string getString()
        {
            return "Sliced Pepperoni";
        }
    }
}

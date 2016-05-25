namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    abstract class Clams
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class FreshClams : Clams
    {
        protected override string getString()
        {
            return "Fresh Clams";
        }
    }

    class FrozenClams : Clams
    {
        protected override string getString()
        {
            return "Frozen Clams";
        }
    }
}

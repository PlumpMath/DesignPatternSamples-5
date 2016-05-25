namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    abstract class Dough
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class ThinCrustDough : Dough
    {
        protected override string getString()
        {
            return "Thin Crust Dough";
        }
    }

    class ThickCrustDough : Dough
    {
        protected override string getString()
        {
            return "Thick Crust Dough";
        }
    }
}

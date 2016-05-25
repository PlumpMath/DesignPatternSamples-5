namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    abstract class Cheese
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class MozzarellaCheese : Cheese
    {
        protected override string getString()
        {
            return "Mozzarella Cheese";
        }
    }

    class ReggianoCheese : Cheese
    {
        protected override string getString()
        {
            return "Reggiano Cheese";
        }
    }

    class ParmesanCheese : Cheese
    {
        protected override string getString()
        {
            return "Parmesan Cheese";
        }
    }
}

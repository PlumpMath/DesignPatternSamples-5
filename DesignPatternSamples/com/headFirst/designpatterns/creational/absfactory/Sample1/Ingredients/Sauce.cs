namespace Com.HeadFirst.DesignPatterns.Creational.AbstractFactory.Sample1.Ingredients
{
    abstract class Sauce
    {
        protected abstract string getString();

        public override string ToString()
        {
            return getString();
        }
    }

    class MarinaraSauce : Sauce
    {
        protected override string getString()
        {
            return "Marinara Sauce";
        }
    }

    class PlumTomatoSauce : Sauce
    {
        protected override string getString()
        {
            return "Plum Tomato Sauce";
        }
    }
}

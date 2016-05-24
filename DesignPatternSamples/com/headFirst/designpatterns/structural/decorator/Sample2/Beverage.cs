namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    enum BeverageSize { Tall = 0, Grand, Venti };

    abstract class Beverage
    {
        public abstract string GetDescription();

        public abstract double GetCost();

        public BeverageSize Size { get; protected set; }
    }
}

namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    class Espresso : Beverage
    {
        private readonly double _price;

        public Espresso(double price, BeverageSize size)
        {
            _price = price;
            Size = size;
        }

        public override double GetCost()
        {
            return _price;
        }

        public override string GetDescription()
        {
            return "Espresso";
        }
    }
}

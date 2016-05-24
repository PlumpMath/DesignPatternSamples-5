namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    class DarkRoast : Beverage
    {
        private readonly double _price;

        public DarkRoast(double price, BeverageSize size)
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
            return "Dark roast coffee";
        }
    }
}

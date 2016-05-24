namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    class HouseBlend : Beverage
    {
        private readonly double _price;

        public HouseBlend(double price, BeverageSize size)
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
            return "House blend coffee";
        }
    }
}

namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    class Mocha : CondimentDecorator
    {
        private readonly double _price;
        public Mocha(Beverage beverage, double price)
            :base(beverage)
        {
            _price = price;
        }
        public override double GetCost()
        {
            return _price + base.GetCost();
        }
    }
}

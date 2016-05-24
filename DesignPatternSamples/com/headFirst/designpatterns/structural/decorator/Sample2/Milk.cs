namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    class Milk : CondimentDecorator
    {
        private readonly double _price;
        public Milk(Beverage beverage, double price)
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

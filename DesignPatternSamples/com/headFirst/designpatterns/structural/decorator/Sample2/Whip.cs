namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    class Whip : CondimentDecorator
    {
        private readonly double _price;
        public Whip(Beverage beverage, double price)
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

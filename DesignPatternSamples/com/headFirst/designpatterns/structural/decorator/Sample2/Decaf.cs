namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    class Decaf : Beverage
    {
        private readonly double _price;

        public Decaf(double price, BeverageSize size)
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
            return "Decaf";
        }
    }
}

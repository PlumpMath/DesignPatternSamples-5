namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample1
{
    class BrownBreadSandwich : ISandwich
    {
        private double _price;

        public BrownBreadSandwich(double price)
        {
            _price = price;
        }

        public double ShowPrice()
        {
            return _price;
        }
    }
}

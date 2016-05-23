namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample1
{
    class WhiteBreadSandwich : ISandwich
    {
        private double _price;

        public WhiteBreadSandwich(double price)
        {
            _price = price;
        }

        public double ShowPrice()
        {
            return _price;
        }
    }
}

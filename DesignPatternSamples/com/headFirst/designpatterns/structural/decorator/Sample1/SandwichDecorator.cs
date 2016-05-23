namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample1
{
    abstract class SandwichDecorator : ISandwich
    {
        private readonly ISandwich _sandwich;
        private readonly double _price;

        public SandwichDecorator(ISandwich sandwich, double price)
        {
            _sandwich = sandwich;
            _price = price;
        }

        public double ShowPrice()
        {
            return _price + _sandwich.ShowPrice();
        }
    }
}

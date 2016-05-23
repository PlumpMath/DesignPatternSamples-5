namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample1
{
    class Cheese : SandwichDecorator
    {
        public Cheese(ISandwich sandwich, double price)
            : base(sandwich, price)
        {

        }
    }
}

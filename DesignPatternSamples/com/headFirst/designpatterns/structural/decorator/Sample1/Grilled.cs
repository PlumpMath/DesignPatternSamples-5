namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample1
{
    class Grilled : SandwichDecorator
    {
        public Grilled(ISandwich sandwich, double price)
            : base(sandwich, price)
        {

        }
    }
}

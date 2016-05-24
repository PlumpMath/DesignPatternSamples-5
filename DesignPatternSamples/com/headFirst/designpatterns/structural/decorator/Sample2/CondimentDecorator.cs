namespace Com.HeadFirst.DesignPatterns.Structural.Decorator.Sample2
{
    abstract class CondimentDecorator : Beverage
    {
        private readonly Beverage _beverage;

        public CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", " + this.GetType().Name;
        }

        public override double GetCost()
        {
            double cost = _beverage.GetCost();

            switch (_beverage.Size)
            {
                case BeverageSize.Tall:
                    cost += 0.10;
                    break;
                case BeverageSize.Grand:
                    cost += 0.15;
                    break;
                case BeverageSize.Venti:
                    cost += 0.20;
                    break;
            }

            return cost;
        }
    }
}

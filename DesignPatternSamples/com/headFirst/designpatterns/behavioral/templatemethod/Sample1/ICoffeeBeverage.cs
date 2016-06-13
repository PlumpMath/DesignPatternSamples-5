namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample1
{
    interface ICoffeeBeverage
    {
        void PrepareRecipe();

        void BoilWater();

        void Brew();

        void PourInCup();

        void AddCondiments();
    }
}

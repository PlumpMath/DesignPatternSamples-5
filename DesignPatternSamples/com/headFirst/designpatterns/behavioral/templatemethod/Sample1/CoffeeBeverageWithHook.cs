using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.TemplateMethod.Sample1
{
    abstract class CoffeeBeverageWithHook : ICoffeeBeverage
    {
        public void AddCondiments()
        {
            addCondiments();
        }

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void Brew()
        {
            brew();
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();

            if (customerWantsCondiments())
                AddCondiments();
        }

        protected abstract void brew();

        protected abstract void addCondiments();

        //Hook method
        protected virtual bool customerWantsCondiments()
        {
            return true;
        }
    }
}

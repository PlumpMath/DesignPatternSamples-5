using System;
namespace Com.HeadFirst.DesignPatterns.Behavioral.Strategy.Sample1
{
    abstract class Bird
    {
        IFlyable _flyable;
        ISwimable _swimable;

        protected Bird()
        {
            _flyable = new NoFlyable(this.GetType().Name);
            _swimable = new NoSwimable(this.GetType().Name);
        }

        public void Fly()
        {
            _flyable.Fly();
        }

        public void Swim()
        {
            _swimable.Swim();
        }

        public void HetchEggs()
        {
            Console.WriteLine("{0} can hetch eggs.", this.GetType().Name);
        }
    }
}

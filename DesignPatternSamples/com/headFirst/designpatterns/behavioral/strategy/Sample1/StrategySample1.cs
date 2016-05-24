using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Strategy.Sample1
{
    class StrategySample1
    {
        static void Main(string[] args)
        {
            Bird penguin = new Penguin();

            penguin.Fly();

            penguin.SetSwimBehavior(new Swimable(nameof(Penguin)));

            penguin.Swim();

            penguin.HetchEggs();

            Bird duck = new Duck();

            duck.SetFlyBehavior(new Flyable(nameof(Duck)));

            duck.SetSwimBehavior(new Swimable(nameof(Duck)));

            duck.Fly();

            duck.Swim();

            duck.HetchEggs();

            Console.Read();
        }
    }
}

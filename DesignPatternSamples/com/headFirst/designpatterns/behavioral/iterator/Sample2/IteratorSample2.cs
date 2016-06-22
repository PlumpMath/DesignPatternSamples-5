using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample2
{
    class IteratorSample2
    {
        static void Main(string[] args)
        {
            Safari safari = new Safari();
            Zoo zoo = new Zoo();

            AnimalGuide guide = new AnimalGuide(safari, zoo);

            guide.PrintAnimals();

            guide.PrintWildAnimals();

            Console.Read();
        }
    }
}

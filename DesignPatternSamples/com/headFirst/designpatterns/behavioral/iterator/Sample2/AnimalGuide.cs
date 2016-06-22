using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample2
{
    class AnimalGuide
    {
        IAnimalEnumerable safari;
        IAnimalEnumerable zoo;

        public AnimalGuide(IAnimalEnumerable safari, IAnimalEnumerable zoo)
        {
            this.safari = safari;
            this.zoo = zoo;
        }

        public void PrintAnimals()
        {
            Console.WriteLine("Animals from safari");
            printAnimals(safari.Enumerator());
            Console.WriteLine("Animals from zoo");
            printAnimals(zoo.Enumerator());
        }

        public void PrintWildAnimals()
        {
            Console.WriteLine("Wild animals from safari");
            printWildAnimals(safari.Enumerator());
            Console.WriteLine("Wild animals from zoo");
            printWildAnimals(zoo.Enumerator());
        }

        void printAnimals(IAnimalEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.CurrentAnimal.Name);
            }
        }

        void printWildAnimals(IAnimalEnumerator enumerator)
        {
            while (enumerator.MoveNext())
            {
                if (enumerator.CurrentAnimal.Wild)
                    Console.WriteLine(enumerator.CurrentAnimal.Name);
            }
        }
    }
}

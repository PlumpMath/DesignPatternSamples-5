using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample2
{
    class Zoo
    {
        ArrayList _animals;

        public Zoo()
        {
            _animals = new ArrayList();
            AddAnimal("African Loin", true);
            AddAnimal("Orang utang", true);
            AddAnimal("Zibra", true);
            AddAnimal("Royal Bengal Tiger", true);
            AddAnimal("Asian Elephant", false);
            AddAnimal("Hippopotamas", false);
            AddAnimal("Spotted Deer", false);
            AddAnimal("Wolf", true);
        }

        public ArrayList GetAnimals()
        {
            return _animals;
        }

        public void AddAnimal(string name, bool wild)
        {
            var item = new Animal(name, wild);
            _animals.Add(item);
        }
    }
}

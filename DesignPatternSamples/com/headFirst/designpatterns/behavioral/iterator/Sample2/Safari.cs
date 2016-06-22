using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample2
{
    class Safari : IAnimalEnumerable
    {
        Animal[] _animals;
        int _counter = 0;
        readonly int MAX_LIMIT = 6;

        public Safari()
        {
            _animals = new Animal[MAX_LIMIT];
            AddAnimal("Raging Bull", true);
            AddAnimal("Rhino", true);
            AddAnimal("Bear", true);
            AddAnimal("Elephant", false);
        }

        public Animal[] GetAnimals()
        {
            return _animals;
        }

        public void AddAnimal(string name, bool wild)
        {
            var item = new Animal(name, wild);

            if (_counter >= MAX_LIMIT)
                Console.WriteLine("Sorry!! can't add more animal");
            else
            {
                _animals[_counter++] = item;
            }
        }

        public IAnimalEnumerator Enumerator()
        {
            return new AnimalEnumerator(_animals.GetEnumerator());
        }
    }
}

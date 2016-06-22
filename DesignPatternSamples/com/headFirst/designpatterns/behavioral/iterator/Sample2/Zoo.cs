using System.Collections;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample2
{
    class Zoo : IAnimalEnumerable
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

        public IAnimalEnumerator Enumerator()
        {
            return new AnimalEnumerator(_animals.GetEnumerator());
        }
    }
}

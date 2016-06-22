using System.Collections;

namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample2
{
    class AnimalEnumerator : IAnimalEnumerator
    {
        IEnumerator _animalEnumerator;

        public AnimalEnumerator(IEnumerator animalEnumerator)
        {
            _animalEnumerator = animalEnumerator;
        }

        public Animal CurrentAnimal
        {
            get
            {
                return _animalEnumerator.Current as Animal;
            }
        }

        public bool MoveNext()
        {
            return _animalEnumerator.MoveNext();
        }
    }
}

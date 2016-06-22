namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample2
{
    interface IAnimalEnumerator
    {
        bool MoveNext();

        Animal CurrentAnimal { get; }
    }
}

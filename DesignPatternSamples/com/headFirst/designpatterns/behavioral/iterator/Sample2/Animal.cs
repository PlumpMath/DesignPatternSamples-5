namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample2
{
    class Animal
    {
        public Animal(string name, bool wild)
        {
            Name = name;
            Wild = wild;
        }

        public string Name { get; private set; }

        public bool Wild { get; private set; }
    }
}

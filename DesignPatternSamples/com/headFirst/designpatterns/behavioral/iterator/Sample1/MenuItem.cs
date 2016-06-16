namespace Com.HeadFirst.DesignPatterns.Behavioral.Iterator.Sample1
{
    class MenuItem
    {
        public MenuItem(string name, string description, bool vegeterian, double price)
        {
            Name = name;
            Description = description;
            Vegeterian = vegeterian;
            Price = price;          
        }

        public string Name { get; private set; }

        public string Description { get; private set; }

        public bool Vegeterian { get; private set; }

        public double Price { get; private set; }
    }
}

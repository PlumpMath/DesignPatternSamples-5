namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample2
{
    interface IEmployee
    {
        string Name { get; }

        double Salary { get; }

        void Add(IEmployee employee);

        void Remove(IEmployee employee);

        void Print();
    }
}

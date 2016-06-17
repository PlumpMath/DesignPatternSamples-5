using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample2
{
    abstract class Employee : IEmployee
    {
        protected Employee(string name, double salary)
        {
            Name = name;
            Salary = salary;
        }

        public string Name { get; private set; }

        public double Salary { get; private set; }

        public virtual void Add(IEmployee employee)
        {
            throw new NotSupportedException();
        }

        public abstract void Print();

        public virtual void Remove(IEmployee employee)
        {
            throw new NotSupportedException();
        }
    }
}

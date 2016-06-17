using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample2
{
    class Developer : Employee
    {
        public Developer(string name, double salary) : base(name, salary) { }

        public override void Print()
        {
            Console.WriteLine("[Name:{0}, Salary{1:0.00}]", Name, Salary);
        }
    }
}

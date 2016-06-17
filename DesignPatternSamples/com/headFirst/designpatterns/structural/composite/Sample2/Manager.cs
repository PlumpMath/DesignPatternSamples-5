using System;
using System.Collections.Generic;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample2
{
    class Manager : Employee
    {
        IList<IEmployee> _employees;

        public Manager(string name, double salary)
            :base(name, salary)
        {
            _employees = new List<IEmployee>();
        }

        public override void Add(IEmployee employee)
        {
            _employees.Add(employee);
        }

        public override void Remove(IEmployee employee)
        {
            _employees.Remove(employee);
        }

        public override void Print()
        {
            Console.WriteLine("[Name:{0}, Salary:{1:0.00}]", Name, Salary);

            foreach(var employee in _employees)
            {
                employee.Print();
            }
        }
    }
}

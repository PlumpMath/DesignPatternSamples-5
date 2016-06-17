using System;

namespace Com.HeadFirst.DesignPatterns.Structural.Composite.Sample2
{
    class CompositeSample2
    {
        static void Main(string[] args)
        {
            IEmployee emp1 = new Developer("John", 10000);
            IEmployee emp2 = new Developer("David", 15000);
            IEmployee manager1 = new Manager("Daniel", 25000);
            manager1.Add(emp1);
            manager1.Add(emp2);
            IEmployee emp3 = new Developer("Michael", 20000);
            IEmployee generalManager = new Manager("Mark", 50000);
            generalManager.Add(emp3);
            generalManager.Add(manager1);
            generalManager.Print();

            Console.Read();
        }
    }
}

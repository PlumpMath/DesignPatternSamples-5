using System;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    class FactoryMethodSample2
    {
        static void Main(string[] args)
        {
            Bank bank = new SBIBank();

            var loan = bank.GetLoan(LoanType.Home, 9.25);

            Console.WriteLine("You are taking {0} loan from {1}", loan.Type, bank.GetName());
            loan.CalculateMonthlyEMI(1000000, 10);

            bank = new ICICIBank();

            loan = bank.GetLoan(LoanType.Education, 9.75);

            Console.WriteLine("You are taking {0} loan from {1}", loan.Type, bank.GetName());
            loan.CalculateMonthlyEMI(100000, 5);

            Console.Read();
        }
    }
}

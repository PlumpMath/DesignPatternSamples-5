using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class StateSample1
    {
        static void Main(string[] args)
        {
            var account = new Account(500);

            account.Deposit(62000);
            account.Withdraw(15000);
            account.Withdraw(8000);
            account.Withdraw(500);
            account.Withdraw(500);
            account.PayInterest();
            account.Withdraw(500);
            account.Withdraw(40000);
            account.Withdraw(100);

            Console.Read();
        }
    }
}

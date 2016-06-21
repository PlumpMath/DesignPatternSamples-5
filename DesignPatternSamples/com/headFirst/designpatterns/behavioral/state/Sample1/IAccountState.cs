namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    interface IAccountState
    {
       void Deposit(double amount);

        void Withdraw(double amount);

        void PayInterest();
    }
}

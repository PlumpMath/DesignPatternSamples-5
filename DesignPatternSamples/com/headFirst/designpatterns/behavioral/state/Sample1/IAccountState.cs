namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    interface IAccountState
    {
        double GetBalance();

        void Deposit(double amount);

        void Withdraw(double amount);

        void PayInterest();
    }
}

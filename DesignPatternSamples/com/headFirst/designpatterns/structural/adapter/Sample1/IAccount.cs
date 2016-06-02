namespace Com.HeadFirst.DesignPatterns.Structural.Adapter.Sample1
{
    interface IAccount
    {
        double GetBalance();
        bool IsOverdraftAvailable();
        void Credit(double balance);
    }
}

namespace Com.HeadFirst.DesignPatterns.Structural.Adapter.Sample1
{
    class ClassTypeAccountAdapter : OffshoreAccount, IAccount
    {
        public ClassTypeAccountAdapter(double balance)
            : base(balance)
        {

        }

        public double GetBalance()
        {
            var taxRate = GetTaxRate();
            var grossBalance = GetOffshoreBalance();
            var taxableBalance = grossBalance * taxRate;
            var balanceAfterTax = grossBalance - taxableBalance;
            return balanceAfterTax;
        }

        public bool IsOverdraftAvailable()
        {
            return false;
        }
    }
}

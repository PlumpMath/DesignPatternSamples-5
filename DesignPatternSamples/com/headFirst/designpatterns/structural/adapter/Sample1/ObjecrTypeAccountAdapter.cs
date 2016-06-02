namespace Com.HeadFirst.DesignPatterns.Structural.Adapter.Sample1
{
    class ObjecrTypeAccountAdapter : Account
    {
        private OffshoreAccount _accout;

        public ObjecrTypeAccountAdapter(OffshoreAccount account)
            : base(account.GetOffshoreBalance())
        {
            _accout = account;
        }

        public override double GetBalance()
        {
            var taxRate = _accout.GetTaxRate();
            var grossBalance = base.GetBalance();
            var taxableBalance = grossBalance * taxRate;
            var balanceAfterTax = grossBalance - taxableBalance;
            return balanceAfterTax;
        }
    }
}

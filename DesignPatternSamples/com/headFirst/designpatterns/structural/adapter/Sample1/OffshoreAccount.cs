namespace Com.HeadFirst.DesignPatterns.Structural.Adapter.Sample1
{
    class OffshoreAccount
    {
        private double _balance;

        const double TAX_RATE = 0.04;

        public OffshoreAccount(double openingBalance)
        {
            _balance = openingBalance;
        }

        public double GetTaxRate()
        {
            return TAX_RATE;
        }

        public double GetOffshoreBalance()
        {
            return _balance;
        }

        public void Credit(double balance)
        {
            _balance += balance;
        }

        public void Debit(double balance)
        {
            if (_balance >= balance)
                _balance -= balance;
        }
    }
}

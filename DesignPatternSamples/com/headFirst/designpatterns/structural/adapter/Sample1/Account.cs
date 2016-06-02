namespace Com.HeadFirst.DesignPatterns.Structural.Adapter.Sample1
{
    class Account : IAccount
    {
        private double _balance;

        private bool _isOverdraftAvaiable;

        public Account(double openingBalance)
        {
            _balance = openingBalance;
        }

        public void Credit(double balance)
        {
            _balance+= balance;
        }

        public virtual double GetBalance()
        {
            return _balance;
        }

        public bool IsOverdraftAvailable()
        {
            return _isOverdraftAvaiable;
        }

        protected void setOverdraftAvailable(bool isOverdraftAvaiable)
        {
            _isOverdraftAvaiable = isOverdraftAvaiable;
        }
    }
}

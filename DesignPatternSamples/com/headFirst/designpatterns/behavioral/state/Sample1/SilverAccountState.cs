namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class SilverAccountState : IAccountState
    {
        Account _accountContext;
        double _balance;

        double _lowerLimit;
        double _upperLimit;
        double _interestRate;

        public SilverAccountState(Account accountContext)
        {
            _accountContext = accountContext;
            _balance = _accountContext.GetBalance();
            initialize();
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            changeState();
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void PayInterest()
        {
            _balance += _interestRate * _balance;
            changeState();
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
            changeState();
        }

        private void initialize()
        {
            _lowerLimit = 0d;
            _upperLimit = 1000d;
            _interestRate = 0d;
        }

        private void changeState()
        {
            if (_balance < _lowerLimit)
                _accountContext.SetState(_accountContext.GetNilState());
            else if (_balance > _upperLimit)
                _accountContext.SetState(_accountContext.GetGoldState());
        }
    }
}

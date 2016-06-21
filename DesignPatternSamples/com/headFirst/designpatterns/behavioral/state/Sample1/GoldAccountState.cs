namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class GoldAccountState : IAccountState
    {
        Account _accountContext;
        double _balance;

        double _lowerLimit;
        double _upperLimit;
        double _interestRate;

        public GoldAccountState(Account accountContext)
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
            _lowerLimit = 1000d;
            _upperLimit = 1000000d;
            _interestRate = 0.05;
        }

        private void changeState()
        {
            if (_balance < 0.00)
            {
                _accountContext.SetState(_accountContext.GetNilState());
            }
            else if (_balance < _lowerLimit)
            {
                _accountContext.SetState(_accountContext.GetSilverState());
            }
        }
    }
}

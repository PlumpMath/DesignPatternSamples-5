namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class GoldAccountState : IAccountState
    {
        Account _accountContext;

        double _lowerLimit;
        double _upperLimit;
        double _interestRate;

        public GoldAccountState(Account accountContext)
        {
            _accountContext = accountContext;
            initialize();
        }

        public void Deposit(double amount)
        {
            _accountContext.Balance += amount;
            changeState();
        }

        public void PayInterest()
        {
            _accountContext.Balance += _interestRate * _accountContext.Balance;
            changeState();
        }

        public void Withdraw(double amount)
        {
            _accountContext.Balance -= amount;
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
            if (_accountContext.Balance < 0.00)
            {
                _accountContext.SetState(_accountContext.GetNilState());
            }
            else if (_accountContext.Balance < _lowerLimit)
            {
                _accountContext.SetState(_accountContext.GetSilverState());
            }
        }
    }
}

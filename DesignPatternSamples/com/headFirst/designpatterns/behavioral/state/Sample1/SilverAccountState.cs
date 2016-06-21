namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class SilverAccountState : IAccountState
    {
        Account _accountContext;

        double _lowerLimit;
        double _upperLimit;
        double _interestRate;

        public SilverAccountState(Account accountContext)
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
            _lowerLimit = 0d;
            _upperLimit = 1000d;
            _interestRate = 0d;
        }

        private void changeState()
        {
            if (_accountContext.Balance < _lowerLimit)
                _accountContext.SetState(_accountContext.GetNilState());
            else if (_accountContext.Balance > _upperLimit)
                _accountContext.SetState(_accountContext.GetGoldState());
        }
    }
}

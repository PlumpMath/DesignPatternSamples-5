namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class Account
    {
        double _balance = 0;
        IAccountState _nilAcountState;
        IAccountState _silverAccountState;
        IAccountState _goldAccountState;

        IAccountState _currentState;

        public Account(double balance)
        {
            _nilAcountState = new NilAccountState(this);
            _silverAccountState = new SilverAccountState(this);
            _goldAccountState = new GoldAccountState(this);
            _balance = balance;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void Deposit(double amount)
        {
            _currentState.Deposit(amount);
            _balance = _currentState.GetBalance();
        }

        public void Withdraw(double amount)
        {
            _currentState.Withdraw(amount);
            _balance = _currentState.GetBalance();
        }

        public void PayInterest()
        {
            _currentState.PayInterest();
            _balance = _currentState.GetBalance();
        }

        public void SetState(IAccountState state)
        {
            _currentState = state;
        }

        public IAccountState GetNilState()
        {
            return _nilAcountState;
        }

        public IAccountState GetSilverState()
        {
            return _silverAccountState;
        }

        public IAccountState GetGoldState()
        {
            return _goldAccountState;
        }
    }
}

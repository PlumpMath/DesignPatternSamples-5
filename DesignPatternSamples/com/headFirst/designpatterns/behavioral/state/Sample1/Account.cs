using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class Account
    {
        IAccountState _nilAcountState;
        IAccountState _silverAccountState;
        IAccountState _goldAccountState;

        IAccountState _currentState;

        public Account(double balance)
        {
            _nilAcountState = new NilAccountState(this);
            _silverAccountState = new SilverAccountState(this);
            _goldAccountState = new GoldAccountState(this);

            Balance = balance;

            if (Balance > 0 && Balance <= 1000)
                _currentState = _silverAccountState;
            else if (Balance > 1000)
                _currentState = _goldAccountState;
            else
                _currentState = _nilAcountState;
        }

        public double Balance
        {
            get; set;
        }

        public void Deposit(double amount)
        {
            _currentState.Deposit(amount);
            Console.WriteLine("Diposit amount: {0:C}----", amount);
            Console.WriteLine("Balance: {0:C}", Balance);
            Console.WriteLine("Status: {0}", _currentState.GetType().Name);
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
            _currentState.Withdraw(amount);
            Console.WriteLine("Withdraw amount: {0:C}----", amount);
            Console.WriteLine("Balance: {0:C}", Balance);
            Console.WriteLine("Status: {0}", _currentState.GetType().Name);
            Console.WriteLine();
        }

        public void PayInterest()
        {
            _currentState.PayInterest();
            Console.WriteLine("Interest paid----");
            Console.WriteLine("Balance: {0:C}", Balance);
            Console.WriteLine("Status: {0}", _currentState.GetType().Name);
            Console.WriteLine();
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

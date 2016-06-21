using System;

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
            Console.WriteLine("Diposit amount: {0:C}----", amount);
            Console.WriteLine("Balance: {0:C}", _balance);
            Console.WriteLine("Status: {0}", _currentState.GetType().Name);
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
            _currentState.Withdraw(amount);
            _balance = _currentState.GetBalance();
            Console.WriteLine("Withdraw amount: {0:C}----", amount);
            Console.WriteLine("Balance: {0:C}", _balance);
            Console.WriteLine("Status: {0}", _currentState.GetType().Name);
            Console.WriteLine();
        }

        public void PayInterest()
        {
            _currentState.PayInterest();
            _balance = _currentState.GetBalance();
            Console.WriteLine("Interest paid----");
            Console.WriteLine("Balance: {0:C}", _balance);
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

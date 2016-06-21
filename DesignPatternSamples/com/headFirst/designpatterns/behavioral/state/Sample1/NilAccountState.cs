using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class NilAccountState : IAccountState
    {
        Account _accountContext;
        double _balance;

        double _lowerLimit;
        double _upperLimit;
        double _serviceFee;

        public NilAccountState(Account accountContext)
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

        public void PayInterest() { }

        public void Withdraw(double amount)
        {
            amount -= _serviceFee;
            Console.WriteLine("No fund is available to withdraw!!");
        }

        private void initialize()
        {
            _lowerLimit = -100d;
            _upperLimit = 0d;
            _serviceFee = 15d;
        }

        private void changeState()
        {
            if (_balance > _upperLimit)
                _accountContext.SetState(_accountContext.GetSilverState());
        }
    }
}

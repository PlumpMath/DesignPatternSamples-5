using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class NilAccountState : IAccountState
    {
        Account _accountContext;

        double _lowerLimit;
        double _upperLimit;
        double _serviceFee;

        public NilAccountState(Account accountContext)
        {
            _accountContext = accountContext;
            initialize();
        }

        public void Deposit(double amount)
        {
            _accountContext.Balance += amount;
            changeState();
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
            if (_accountContext.Balance > _upperLimit)
                _accountContext.SetState(_accountContext.GetSilverState());
        }
    }
}

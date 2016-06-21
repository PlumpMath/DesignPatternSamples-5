using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public IAccountState GetNilState()
        {
            
        }

        public IAccountState GetSilverState()
        {

        }

        public IAccountState GetGoldState()
        {

        }
    }
}

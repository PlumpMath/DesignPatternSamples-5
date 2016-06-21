using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample1
{
    class GoldAccountState : IAccountState
    {
        Account _accountContext;
        double _balance;

        public GoldAccountState(Account accountContext)
        {
            _accountContext = accountContext;
            _balance = _accountContext.GetBalance();
        }

        public void Deposit(double amount)
        {
            throw new NotImplementedException();
        }

        public double GetBalance()
        {
            return _balance;
        }

        public void PayInterest()
        {
            throw new NotImplementedException();
        }

        public void Withdraw(double amount)
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample2
{
    class WinnerState : IState
    {
        GumballMachine _gumballMachine;

        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            _gumballMachine.ReleaseBall();
            if (_gumballMachine.GetCount() == 0)
                _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
            else
            {
                _gumballMachine.ReleaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");
                if (_gumballMachine.GetCount() > 0)
                    _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
                else
                {
                    Console.WriteLine("Oops, out of gumballs!");
                    _gumballMachine.SetState(_gumballMachine.GetSoldOutState());
                }
            }
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void InsertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a Gumball");
        }

        public void Refill() { }

        public void TurnCrank()
        {
            Console.WriteLine("Turning again doesn't get you another gumball!");
        }

        public override string ToString()
        {
            return "despensing two gumballs for your quarter, because YOU'RE A WINNER!";
        }
    }
}

using System;

namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample2
{
    class HasQuarterState : IState
    {
        GumballMachine _gumballMachine;

        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }

        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.SetState(_gumballMachine.GetNoQuarterState());
        }

        public void InsertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void Refill() { }

        public void TurnCrank()
        {
            Console.WriteLine("You turned....");
            _gumballMachine.SetState(_gumballMachine.GetSoldState());
        }

        public override string ToString()
        {
            return "waiting for turn of crank";
        }
    }
}

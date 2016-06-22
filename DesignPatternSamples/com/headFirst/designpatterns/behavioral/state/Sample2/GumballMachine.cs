using System;
using System.Text;

namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample2
{
    class GumballMachine
    {
        IState _soldOutState;
        IState _noQuarterState;
        IState _hasQuarterState;
        IState _soldState;

        IState _state;
        int _gumballCount = 0;

        public GumballMachine(int numberOfGumballs)
        {
            _noQuarterState = new NoQuarterState(this);
            _gumballCount = numberOfGumballs;
        }

        public void InsertQuarter()
        {
            _state.InsertQuarter();
        }

        public void EjectQuarter()
        {
            _state.EjectQuarter();
        }

        public void TurnCrank()
        {
            _state.TurnCrank();
            _state.Dispense();
        }

        public void ReleaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot...");
            if (_gumballCount != 0)
                _gumballCount--;
        }

        public int GetCount()
        {
            return _gumballCount;
        }

        public void Refill(int count)
        {
            _gumballCount += count;
            Console.WriteLine("The gumball machine was just refilled; it's new count is: {0}", _gumballCount);
            _state.Refill();
        }

        public void SetState(IState state)
        {
            _state = state;
        }

        public IState GetSoldOutState()
        {
            return _soldOutState;
        }

        public IState GetNoQuarterState()
        {
            return _noQuarterState;
        }

        public IState GetHasQuarterState()
        {
            return _hasQuarterState;
        }

        public IState GetSoldState()
        {
            return _soldState;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.Append("\r\nMighty Gumball, Inc.");
            builder.Append("\r\n.Net-enabled Standing Gumball Model #2016");
            builder.AppendFormat("\r\nInventory: {0} gumball(s)", _gumballCount);
            builder.AppendFormat("\r\nMachine is {0} \r\n", _state.ToString());
            return builder.ToString();
        }
    }
}

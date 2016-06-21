namespace Com.HeadFirst.DesignPatterns.Behavioral.State.Sample2
{
    interface IState
    {
        void InsertQuarter();

        void EjectQuarter();

        void TurnCrank();

        void Dispense();

        void Refill();
    }
}

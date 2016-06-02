namespace Com.HeadFirst.DesignPatterns.Structural.Adapter.Sample1
{
    class StandardAccount : Account
    {
        public StandardAccount(double openingBalance)
            : base(openingBalance)
        {
            setOverdraftAvailable(false);
        }
    }
}

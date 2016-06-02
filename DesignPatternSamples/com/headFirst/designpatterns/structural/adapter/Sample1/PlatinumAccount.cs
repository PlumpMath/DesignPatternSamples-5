namespace Com.HeadFirst.DesignPatterns.Structural.Adapter.Sample1
{
    class PlatinumAccount : Account
    {
        public PlatinumAccount(double openingBalance)
            : base(openingBalance)
        {
            setOverdraftAvailable(true);
        }
    }
}

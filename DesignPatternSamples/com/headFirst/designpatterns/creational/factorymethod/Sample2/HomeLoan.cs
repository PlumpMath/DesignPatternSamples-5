namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    class HomeLoan : Loan
    {
        public HomeLoan(double interestRate) : base(interestRate, LoanType.Home) { }
    }
}

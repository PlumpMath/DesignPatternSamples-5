namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    class BusinessLoan : Loan
    {
        public BusinessLoan(double interestRate) : base(interestRate, LoanType.Business) { }
    }
}

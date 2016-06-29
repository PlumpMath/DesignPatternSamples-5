namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    class EducationLoan : Loan
    {
        public EducationLoan(double interestRate) : base(interestRate, LoanType.Education) { }
    }
}

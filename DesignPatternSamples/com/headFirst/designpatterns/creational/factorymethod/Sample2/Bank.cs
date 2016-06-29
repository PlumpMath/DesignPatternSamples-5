namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    abstract class Bank : IBank
    {
        public Loan GetLoan(LoanType type, double interestRate)
        {
            return LoanFactory.CreateLoanInstance(type, interestRate);
        }

        public abstract string GetName();
    }
}

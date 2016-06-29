namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    interface IBank
    {
        string GetName();

        Loan GetLoan(LoanType type, double interestRate);
    }
}

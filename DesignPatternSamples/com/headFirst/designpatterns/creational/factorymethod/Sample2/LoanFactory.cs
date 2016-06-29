namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    class LoanFactory
    {
        public static Loan CreateLoanInstance(LoanType type, double interestRate)
        {
            Loan loanObject = default(Loan);

            switch (type)
            {
                case LoanType.Business:
                    loanObject = new BusinessLoan(interestRate);
                    break;
                case LoanType.Education:
                    loanObject = new EducationLoan(interestRate);
                    break;
                case LoanType.Home:
                    loanObject = new HomeLoan(interestRate);
                    break;
            }

            return loanObject;
        }
    }
}

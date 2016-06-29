using System;

namespace Com.HeadFirst.DesignPatterns.Creational.FactoryMethod.Sample2
{
    public enum LoanType { Home, Business, Education};

    abstract class Loan
    {
        private double _interestRate;
        private LoanType _loanType;
        const int MONTH_IN_YEAR = 12;

        protected Loan(double interestRate, LoanType loanType)
        {
            _interestRate = interestRate;
            _loanType = loanType;
        }

        public double InterestRate { get { return _interestRate; } }

        public LoanType Type { get { return _loanType; } }

        public void CalculateMonthlyEMI(double loanAmount, int years)
        {
            /* 
              to calculate the monthly loan payment i.e. EMI   
                            
              rate=annual interest rate/12*100; 
              n=number of monthly installments;            
              1year=12 months. 
              so, n=years*12; 
 
            */

            double emi;
            int n;

            n = years * MONTH_IN_YEAR;
            _interestRate = _interestRate / (MONTH_IN_YEAR * 100);
            emi = ((_interestRate * Math.Pow((1 + _interestRate), n)) / ((Math.Pow((1 + _interestRate), n)) - 1)) * loanAmount;
            Console.WriteLine("Your monthly EMI is {0} for the amount {1} you have borrowed", emi, loanAmount);
        }
    }
}

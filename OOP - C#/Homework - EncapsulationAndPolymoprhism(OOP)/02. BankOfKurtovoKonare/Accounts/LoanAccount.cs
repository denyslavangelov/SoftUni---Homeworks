using System;
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    class LoanAccount : BankAccount
    {
        public LoanAccount(ICustomer customer, decimal balance, decimal interestRate) 
            : base(customer, balance, interestRate)
        {
        }

        public override decimal CalculateInterest(int periodInMonths)
        {
            int monthsWithoutInterest = 0;
            switch (this.Customer.Type)
            {
                case CustomerType.Company:
                    monthsWithoutInterest = 2;
                    break;
                case CustomerType.Individual:
                    monthsWithoutInterest = 3;
                    break;
            }

            int monthsWithInterest = Math.Max(0, periodInMonths - monthsWithoutInterest);
            decimal interest = base.CalculateInterest(monthsWithInterest);

            return interest;
        }
    }
}
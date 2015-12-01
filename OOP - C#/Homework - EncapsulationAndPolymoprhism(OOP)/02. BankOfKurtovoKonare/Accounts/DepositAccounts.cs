using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
   class DepositAccounts : BankAccount, IWithdrawable
    {
        public DepositAccounts(ICustomer customer, decimal balance, decimal interestRate) 
            :base(customer, balance, interestRate)
        {
        }

        public void WithdrawMoney(decimal amountToWithdraw)
        {
            this.Balance -= amountToWithdraw;
        }

        public override decimal CalculateInterest(int months)
        {
            decimal interest;
            if (this.Balance < 0 && this.Balance < 1000)
            {
                interest = base.CalculateInterest(0);
            }
            else
            {
                interest = base.CalculateInterest(months);
            }

            return interest;
        }
    }
}
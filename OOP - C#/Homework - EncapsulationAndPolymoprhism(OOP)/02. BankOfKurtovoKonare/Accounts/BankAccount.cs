using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    abstract class BankAccount : IAccount, IDepositable
    {
        protected BankAccount(ICustomer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public decimal InterestRate { get; set; }

        public decimal Balance { get; set; }

        public ICustomer Customer { get; set; }


        public void DepositAmountToAccount(decimal ammountToDeposit)
        {
            this.Balance += ammountToDeposit;
        }

        public virtual decimal CalculateInterest(int months)
        {
            decimal interest = this.Balance * (1 + this.InterestRate * months);
            return interest;
        }
    }
}
namespace _02.BankOfKurtovoKonare.Interfaces
{
    public interface IAccount
    {
        decimal InterestRate { get; set; }

        decimal Balance { get; set; }

        ICustomer Customer { get; set; }

        decimal CalculateInterest(int months);
    }
}
using System;
using _02.BankOfKurtovoKonare.Interfaces;

namespace _02.BankOfKurtovoKonare
{
    class BankMain
    {
        static void Main()
        {
            IAccount[] accounts =
            {
                new DepositAccounts(new Customer(CustomerType.Individual, "Denislav"), 1050.25m, 0.0055m),
                new LoanAccount(new Customer(CustomerType.Company, "Martin"), -10000, 0.0005m),
                new MortgageAccount(new Customer(CustomerType.Individual, "Niki"), -50000, 0.0011m),
                new DepositAccounts(new Customer(CustomerType.Company, "Borislav"), 1000000, 0.00075m),
            };

            Console.WriteLine(
                "12-month interest on a deposit account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[0].Balance,
                accounts[0].InterestRate * 100,
                accounts[0].CalculateInterest(12));

            Console.WriteLine(
                "3-month interest on a loan account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[1].Balance,
                accounts[1].InterestRate * 100,
                accounts[1].CalculateInterest(3));

            Console.WriteLine(
                "15-month interest on a mortgage account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[2].Balance,
                accounts[2].InterestRate * 100,
                accounts[2].CalculateInterest(15));

            Console.WriteLine(
                "24-month interest on a deposit account (balance: {0:c2}, rate: {1:f3}%): {2:c2}",
                accounts[3].Balance,
                accounts[3].InterestRate * 100,
                accounts[3].CalculateInterest(24));
        }
    }
}

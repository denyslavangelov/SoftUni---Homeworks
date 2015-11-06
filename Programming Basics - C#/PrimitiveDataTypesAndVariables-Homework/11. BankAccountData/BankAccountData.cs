using System;

class BankAccountData
{
    static void Main()
    {
        // Input
        Console.WriteLine("Enter your first name : ");
        string firstName = Console.ReadLine();

        Console.WriteLine("Enter your middle name : ");
        string middleName = Console.ReadLine();

        Console.WriteLine("Enter your last name : ");
        string lastName = Console.ReadLine();

        Console.WriteLine("Enter your balance : ");
        double balance = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter your bankName : ");
        string bankName = Console.ReadLine();

        Console.WriteLine("Enter your IBAN : ");
        int iban = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your first credit card number : ");
        int firstCreditCardNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your second credit card number : ");
        int secondCreditCardNumber = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter your third credit card number : ");
        int thirdCreditCardNumber = int.Parse(Console.ReadLine());

        // Output
        Console.WriteLine();
        Console.WriteLine();

        Console.WriteLine("Your info :\n");
        Console.WriteLine("First name : {0}", firstName);
        Console.WriteLine("Middle name : {0}", middleName);
        Console.WriteLine("Last name : {0}", lastName);
        Console.WriteLine("Balance : {0}", balance);
        Console.WriteLine("Bank Name : {0}", bankName);
        Console.WriteLine("IBAN : {0}", iban);
        Console.WriteLine("First credit card № : {0}", firstCreditCardNumber);
        Console.WriteLine("Second credit card № : {0}", secondCreditCardNumber);
        Console.WriteLine("Third credit card № : {0}", thirdCreditCardNumber);

    }
}


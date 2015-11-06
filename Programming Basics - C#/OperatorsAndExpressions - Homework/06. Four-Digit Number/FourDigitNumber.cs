using System;

class FourDigitNumber
{
    static void Main()
    {
        // Input
        Console.Write("Please enter a four-digit number : ");
        int number = int.Parse(Console.ReadLine());

        // Logic
        int firstDigit = number / 1000;

        int secondDigit = (number / 100) % 10;

        int thirdDigit = (number / 10) % 10;

        int fourthDigit = number % 10;

        int sumOfAllDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;

        //Output
        Console.WriteLine();
        Console.WriteLine("The sum of all digits is : {0}", sumOfAllDigits);
        Console.WriteLine();
        Console.WriteLine("Reversed digits : {0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine();
        Console.WriteLine("Last digit infront : {0}{1}{2}{3}", fourthDigit, firstDigit, secondDigit, thirdDigit);
        Console.WriteLine();
        Console.WriteLine("Second and third digit exchanged : {0}{1}{2}{3}", firstDigit, thirdDigit, secondDigit, fourthDigit);
    }
}


using System;

class ExchangeIfGreater
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your first number : ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter your second number : ");
        double secondNumber = double.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic and output.
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("Result : {0} {1}",secondNumber, firstNumber);
        }
        else if (secondNumber > firstNumber)
        {
            Console.WriteLine("Result : {0} {1}",firstNumber, secondNumber);
        }
    }
}


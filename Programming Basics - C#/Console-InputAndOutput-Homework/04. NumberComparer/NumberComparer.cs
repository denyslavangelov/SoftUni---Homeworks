using System;

class NumberComparer
{
    static void Main()
    {
        // Input.
        Console.Write("Enter first number : ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number : ");
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic and output.
        if (firstNumber > secondNumber)
        {
            Console.WriteLine("Number {0} is greater than number {1}.", firstNumber, secondNumber);
        }
        else
        {
            Console.WriteLine("Number {0} is greater than number {1}.", secondNumber, firstNumber);
        }
    }
}


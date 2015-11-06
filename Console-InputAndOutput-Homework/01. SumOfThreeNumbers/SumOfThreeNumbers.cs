using System;

class SumOfThreeNumbers
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your first number : ");
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your second number : ");
        int secondNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter your third number : ");
        int thirdNumber = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // Output.
        Console.WriteLine("Sum of {0} + {1} + {2} is : {3}", firstNumber, secondNumber, thirdNumber, firstNumber + secondNumber + thirdNumber);

    }
}


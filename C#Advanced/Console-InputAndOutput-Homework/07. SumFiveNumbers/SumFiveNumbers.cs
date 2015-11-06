using System;

class SumFiveNumbers
{
    static void Main()
    {
        Console.WriteLine("Please enter 5 numbers with spaces between them : ");

        // Spaces.
        Console.WriteLine();

        // Input and Logic.
        string[] userINput = Console.ReadLine().Split(' ');

        double firstNumber = double.Parse(userINput[0]);
        double secondNumber = double.Parse(userINput[1]);
        double thirdNumber = double.Parse(userINput[2]);
        double forthNumber = double.Parse(userINput[3]);
        double fifthNumber = double.Parse(userINput[4]);

        
        double sumOfAll = firstNumber + secondNumber + thirdNumber + forthNumber + fifthNumber;

        // Spaces.
        Console.WriteLine();

        // Output.
        Console.WriteLine("The result is : {0}", sumOfAll);
    }
}


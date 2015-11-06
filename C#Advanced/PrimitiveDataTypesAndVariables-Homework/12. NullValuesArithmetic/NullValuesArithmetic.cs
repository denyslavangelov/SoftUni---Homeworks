using System;

class NullValuesArithmetic
{
    static void Main()
    {
        int? firstNumber = null;
        double? secondNumber = null;

        // Output
        Console.WriteLine(firstNumber);
        Console.WriteLine(secondNumber);

        firstNumber = 2;
        Console.WriteLine(firstNumber);

        secondNumber = 2.5;
        Console.WriteLine(secondNumber);


    }
}


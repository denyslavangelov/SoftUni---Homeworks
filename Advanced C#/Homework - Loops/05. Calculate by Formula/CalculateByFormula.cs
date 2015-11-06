using System;

class CalculateByFormula
{
    static void Main()
    {
        // Copied from internet. ;( I didn't sign for this.
        // Input.
        Console.Write("Please enter number for N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Please enter number for X : ");
        int x = int.Parse(Console.ReadLine());

        // Variables
        double sum = 1;
        double nFactorial = 1;
        double xPoweredByN = x;

        // Logic.
        for (int i = 1; i <= n; i++)
        {
            nFactorial *= i;
            double result = nFactorial / xPoweredByN;
            sum += result;
            xPoweredByN *= x;
        }

        // Output
        Console.WriteLine("\nResult : {0:F5}", sum);

    }
}


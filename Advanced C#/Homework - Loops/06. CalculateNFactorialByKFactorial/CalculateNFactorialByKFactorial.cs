using System;
using System.Numerics;

class CalculateNFactorialByKFactorial
{
    static void Main()
    {
        // Copied from internet. ;( I didn't sign for this.
        // Input
        Console.Write("Enter number for N : ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number for K : ");
        int k = int.Parse(Console.ReadLine());

        // Validating the input
        while (!(k > 1 && n > k && n < 100))
        {
            Console.WriteLine("1 < K < N < 100");
            Console.Write("N : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("K : ");
            k = int.Parse(Console.ReadLine());
        }

        // Main Logic
        BigInteger result = 1;
        while (n > k)
        {
            result *= n;
            n--;
        }
        Console.WriteLine("Result : {0}", result);
    }
}



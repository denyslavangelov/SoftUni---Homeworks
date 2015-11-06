using System;

class TrailingZeroesInNFactorial
{
    static void Main()
    {
        Console.Write("Enter a number N to find how many trailing zeros N! contains : ");
        int N = int.Parse(Console.ReadLine());

        int countOfZeroes = 0;

        for (int i = 1; Math.Pow(5, i) <= N; i++)
        {
            countOfZeroes += N / (int)Math.Pow(5, i);
        }

        Console.WriteLine("\nThere are {0} trailing zeros in {1}!.\n", countOfZeroes, N);
    }
}
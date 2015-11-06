using System;

class NumbersFromOneToN
{
    static void Main()
    {
        // Input.
        int n = int.Parse(Console.ReadLine());

        // Logic and Output.
        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine(i);
        }
    }
}


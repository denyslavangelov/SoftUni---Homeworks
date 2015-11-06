using System;

class NewHouse
{
    static void Main()
    {
        // Pretty easy.

        // Input.
        int n = int.Parse(Console.ReadLine());


        // Roof.
        for (int i = 0; i < (n / 2) + 1; i++)
        {
            Console.WriteLine("{0}{1}{0}", new string('-', n / 2 - i), new string('*', 1 + 2*i));
        }

        // Main house.
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("|{0}|", new string('*', n - 2));
        }
    }
}


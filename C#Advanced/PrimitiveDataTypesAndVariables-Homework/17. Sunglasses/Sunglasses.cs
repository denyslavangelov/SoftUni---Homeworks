using System;

class Sunglasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        // Static ( First Line )
        Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
 
        // Loop ( Middle + Bridge )
        for (int i = 0; i < n - 2; i++)
			{
                Console.WriteLine("*{0}*{1}*{0}*", new string('/', n * 2 - 2), new string((i == n/2  - 1) ? '-' : ' ', n));
			}
       
        // Static ( Last Line )
        Console.WriteLine("{0}{1}{0}", new string('*', n * 2), new string(' ', n));
    }
}


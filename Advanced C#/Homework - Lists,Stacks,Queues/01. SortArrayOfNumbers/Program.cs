using System;
using System.Collections.Generic;
using System.Linq;

class SortArrayOfNumbers
{
    static void Main()
    {
        Console.Write("Enter your numbers : ");
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        Array.Sort(array);

        Console.Write("Sorted numbers : ");

        foreach (var num in array)
        {
            Console.Write("{0} ", num);
        }

        Console.ReadLine();


    }
}


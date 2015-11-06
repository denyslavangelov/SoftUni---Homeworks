using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int counter = 1;
        int maxLength = 0;
        int endElement = 0;

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > array[i - 1])
            {
                Console.Write("{0} ", array[i]);
                counter++;
            }
            else
            {
                counter = 1;
                Console.Write("{0} ", array[i]);
            }

            if (counter > maxLength)
            {
                maxLength = counter;
                endElement = i;
            }
        }

        Console.WriteLine();
        Console.Write("Longest : ");

        for (int j = endElement - maxLength + 1; j <= endElement; j++)
        {
            Console.Write("{0} ", endElement);
        }

    }
}


using System;
using System.Linq;

class SortArrayBySelection
{
    static void Main()
    {
        Console.Write("Enter your numbers : ");
        int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int temp = 0;
        int minValue = 0;

        for (int i = 0; i < arr.Length - 1; i++)
        {
            minValue = i;
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[j] < arr[minValue])
                {
                    minValue = j;
                }
            }
            temp = arr[i];
            arr[i] = arr[minValue];
            arr[minValue] = temp;
        }

        Console.Write("Sorted : ");
        for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + " ");

        Console.WriteLine();

    }
}


using System;
using System.Collections.Generic;
using System.Linq;

class CategorizeNumbers
{
    static void Main()
    {
        Console.Write("Enter your numbers : ");
        double[] arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

        List<double> roundNumbers = new List<double>();
        List<double> floatPointNumbers = new List<double>();

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 1 != 0)
            {
                floatPointNumbers.Add(arr[i]);
            }
            else
            {
                roundNumbers.Add(arr[i]);
            }
        }

        Console.WriteLine("Rounded numbers : [{0}]", string.Join(" ", roundNumbers));
        Console.WriteLine("min : {0}", roundNumbers.Min());
        Console.WriteLine("max : {0}", roundNumbers.Max());
        Console.WriteLine("sum : {0}", roundNumbers.Sum());
        Console.WriteLine("avg : {0:f2}", roundNumbers.Average());

        Console.WriteLine();

        Console.WriteLine("Floating-point numbers : [{0}]", string.Join(" ", floatPointNumbers));
        Console.WriteLine("min : {0}", floatPointNumbers.Min());
        Console.WriteLine("max : {0}", floatPointNumbers.Max());
        Console.WriteLine("sum : {0}", floatPointNumbers.Sum());
        Console.WriteLine("avg : {0:f2}", floatPointNumbers.Average());

    }
}


﻿using System;

class SumOfNumbers
{
    static void Main()
    {
        // Input
        Console.WriteLine("Enter your numbers : ");
        int n = int.Parse(Console.ReadLine());

        // Logic
        double sum = 0;
        for (int i = 0; i < n; i++)
        {
            double number = double.Parse(Console.ReadLine());
            sum += number;
        }

        // Output
        Console.WriteLine("Sum : {0}", sum);
    }
}


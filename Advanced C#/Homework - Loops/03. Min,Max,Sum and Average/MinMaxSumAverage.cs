using System;

class Min_Max_Sum_AvgOfNNumbers
{
    static void Main()
    {
        // Input
        Console.Write("How many numbers do you wish to enter? ");
        int n = int.Parse(Console.ReadLine());

        // Array.
        int[] arrayOfNumbers = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write("Enter number [{0}]: ", i + 1);
            arrayOfNumbers[i] = int.Parse(Console.ReadLine());
        }

        // Make variables with starting value for minNumber,maxNumber and Sum.
        int minNumber = arrayOfNumbers[0];
        int maxNumber = arrayOfNumbers[0];
        int sumOfNumbers = 0;

        // Check for min,max and sum of numbers.
        for (int i = 0; i < n; i++)
        {
            if (arrayOfNumbers[i] < minNumber)
            {
                minNumber = arrayOfNumbers[i];
            }
            else if (arrayOfNumbers[i] > maxNumber)
            {
                maxNumber = arrayOfNumbers[i];
            }

            sumOfNumbers += arrayOfNumbers[i];
        }
        // Make the sum double.
        double sumDouble = (double)sumOfNumbers;
        double average = sumDouble / n;

        Console.WriteLine("\nResult : ");

        Console.WriteLine("The min number is : {0}", minNumber);
        Console.WriteLine("The max number is : {0}", maxNumber);
        Console.WriteLine("The sum of the numbers is : {0}", sumOfNumbers);
        Console.WriteLine("The average sum of the numbers is : {0:f2}", average);
    }
}
using System;
using System.Linq;
using System.Collections.Generic;

class SumOfElements
{
    public static void Main()
    {
        // Didn't know how to do it. Copy-pasted so I can take a look.
        // Source : http://pastebin.com/5wB72pud


        string inputLine = Console.ReadLine(); //The input line
        string[] input = inputLine.Split(' '); //Converts the input line to string
        long[] numbers = Array.ConvertAll(input, long.Parse); //Converts the sting array to int array
        long maxNumber = numbers.Max(); //Gets the max number of the array
        long totalSumOfNumber = numbers.Sum(); //Gets the total sum of the numbers in the array
        long check = totalSumOfNumber - maxNumber; //Gets the sum of the numbers int the array without the max number

        if (check == maxNumber) //Checks if the sum is equal to the max number
        {
            Console.WriteLine("Yes, sum={0}", check);
        }
        else
        {
            long result = check - maxNumber;
            if (result < 0)
            {
                Console.WriteLine("No, diff={0}", result * (-1));
            }
            else
            {
                Console.WriteLine("No, diff={0}", result);
            }
        }
    }
}
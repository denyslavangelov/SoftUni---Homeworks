using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Pairs
{
    static void Main(string[] args)
    {
        // Get the numbers.
        string input = Console.ReadLine();
        // Put them in a array and split them.
        string[] digits = input.Split(' ');
        // Get the length of the digits.
        int len = digits.Length;
        // Get the first two digits and put them into one pair.
        int prevPairSum = int.Parse(digits[0]) + int.Parse(digits[1]);
        int diff = new int();
        int maxDiff = new int();

        for (int i = 2; i < len - 1; i += 2)
        {
            // Calculate the sum from the pair.
            int pairSum = int.Parse(digits[i]) + int.Parse(digits[i + 1]);
            // Calculate the difference between the pairs.
            diff = Math.Abs(prevPairSum - pairSum);
            if (diff > maxDiff)
            {
                maxDiff = diff;
            }
            prevPairSum = pairSum;

        }
        // Output.
        if (diff != 0)
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
        else
        {
            Console.WriteLine("Yes, value={0}", prevPairSum);
        }
    }
}
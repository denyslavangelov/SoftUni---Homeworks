using System;
using System.Linq;

class SequenceOfEqualStrings
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        var list = input.GroupBy(x => x.ToLower());

        foreach (var sequence in list)
        {
            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}


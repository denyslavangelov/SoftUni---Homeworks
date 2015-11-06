using System;

class Program
{
    static void Main()
    {
        // Input and output.
        string input = Console.ReadLine();
        Console.WriteLine(ReverseString(input));
    }

    private static string ReverseString(string input)
    {
        // Logic.
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}


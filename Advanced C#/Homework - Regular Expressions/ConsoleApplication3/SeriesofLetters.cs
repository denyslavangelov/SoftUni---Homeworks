using System;
using System.Text.RegularExpressions;

class SeriesofLetters
{
    static void Main()
    {
        string inputString = Console.ReadLine();

        var regex = new Regex(@"(.)\1+");

        Console.WriteLine(regex.Replace(inputString, "$1"));
    }
}


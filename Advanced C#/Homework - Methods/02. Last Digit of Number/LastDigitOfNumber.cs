using System;

class LastDigitOfNumber
{
    static void Main()
    {
        Console.Write("Please enter an integer number : ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Output : {0}", GetLastDigitAsWord(number));
    }

    private static string GetLastDigitAsWord(int number)
    {
        string digitAsWord = String.Empty;
        int digit = number % 10;

        switch (digit)
        {
            case 1:
                digitAsWord = "One";
            break;
            case 2:
                digitAsWord = "Two";
                break;
            case 3:
                digitAsWord = "Three";
                break;
            case 4:
                digitAsWord = "Four";
                break;
            case 5:
                digitAsWord = "Five";
                break;
            case 6:
                digitAsWord = "Six";
                break;
            case 7:
                digitAsWord = "Seven";
                break;
            case 0:
                digitAsWord = "Zero";
                break;
        }

        return digitAsWord;

    }
}


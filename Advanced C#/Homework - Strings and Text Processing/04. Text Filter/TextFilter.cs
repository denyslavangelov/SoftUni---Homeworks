using System;

class TextFilter
{
    static void Main()
    {
        // Input. 
        string[] bannedWords = Console.ReadLine().Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
        string inputText = Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Censored : ");
        Console.WriteLine();

        // Logic and output.
        foreach (var word in bannedWords)
        {
            inputText = inputText.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(inputText);
    }
}


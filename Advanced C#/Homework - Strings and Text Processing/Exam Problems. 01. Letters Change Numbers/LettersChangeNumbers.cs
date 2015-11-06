using System;

class LettersChangeNumbers
{
    static void Main()
    {
        char[] inputString = Console.ReadLine().ToCharArray();

        bool isUpper = false;

        if (char.IsUpper(inputString[0]))
        {
            isUpper = true;
        }

        int index = char.ToUpper(inputString[0]) - 64;
        int sum = 0;

        for (int i = 0; i < inputString.Length - 1; i++)
        {
            if (isUpper)
            {
                sum += inputString[i + 1] / index;
            }
        }

        Console.WriteLine(sum);

        


    }
}


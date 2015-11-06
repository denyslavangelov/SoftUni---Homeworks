using System;

class DeclareVariables
{
    static void Main()
    {
        // 97, -115, -10000, 52130, 4825932

        byte firstNumber = 97;
        sbyte secondNumber = -115;
        short thirdNumber = -10000;
        ushort fourthNumber = 52130;
        int fifthNumber = 4825932;

        // First option.
        Console.WriteLine("First number is: {0}\nSecond number is: {1}\nThird number is: {2}\nFourth number is: {3}:\nFifth number is: {4}",
                            firstNumber, secondNumber, thirdNumber, fourthNumber, fifthNumber);

        // Spaces
        Console.WriteLine();
        Console.WriteLine();

        // Second option.
        Console.WriteLine("First number is: {0}", firstNumber);
        Console.WriteLine("Second number is: {0}", secondNumber);
        Console.WriteLine("Third number is: {0}", thirdNumber);
        Console.WriteLine("Fourth number is: {0}", fourthNumber);
        Console.WriteLine("Fifth number is: {0}", fifthNumber);




    }
}


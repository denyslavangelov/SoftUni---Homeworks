using System;

class BonusScore
{
    static void Main()
    {
        // Input.
        Console.Write("Enter your score (integer between 1 - 9) : ");
        int score = int.Parse(Console.ReadLine());

        Console.WriteLine();

        // Logic and output.
        switch (score)
    	{
            case 1:
            case 2:
            case 3: Console.Write("Your score is multiplied by 10 : {0}", score * 10);
            break;
            case 4:
            case 5:
            case 6: Console.Write("Your score is multiplied by 100 : {0}", score * 100);
            break;
            case 7:
            case 8:
            case 9: Console.WriteLine("Your score is multiplied by 1000 : {0}", score * 1000);
            break;
		    default: Console.WriteLine("Invalid Score.");
            break;
	    }
        Console.WriteLine();
    }
 }


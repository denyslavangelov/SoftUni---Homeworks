using System;

class DecckOfCards
{
    static void Main()
    {
        // Variables for all the symbols.
        char club = '\u2663';
        char spade = '\u2660';
        char diamond = '\u2666';
        char heart = '\u2665';

        string card = "";

        // Loop.
        for (int i = 2; i < 13; i++)
        {
            card = i.ToString();

            // Switch-case for non-numeric cards.
            switch (i)
            {
                case 10: card = "K";
                    break;
                case 11:
                    card = "Q";
                    break;
                case 12:
                    card = "K";
                    break;
                case 13:
                    card = "A";
                    break;
            }

            // Output.
            Console.Write(card); Console.Write(club);
            Console.Write(card); Console.Write(diamond);
            Console.Write(card); Console.Write(heart);
            Console.Write(card); Console.Write(spade);
        }
        Console.WriteLine();


    }
}


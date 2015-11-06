using System;

class FirstLargerThanNeighbours
{
    static void Main()
    {
        int[] sequanceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequanceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequanceThree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFirstElementLargerThaNeighbours(sequanceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThaNeighbours(sequanceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThaNeighbours(sequanceThree));

    }

    private static int GetIndexOfFirstElementLargerThaNeighbours(int[] sequanceOne)
    {
        int largestNumber = 0;

        for (int i = 0; i < sequanceOne.Length; i++)
        {
            if (sequanceOne[i] > sequanceOne[i + 1] && sequanceOne[i] > sequanceOne[i - 1])
            {
                largestNumber = sequanceOne[i];
            }
        }

        return largestNumber;
    }
}


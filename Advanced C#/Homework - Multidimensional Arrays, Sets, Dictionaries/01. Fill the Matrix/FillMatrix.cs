using System;

    class FillMatrix
    {
        static int n = 0;

        // Pattern for first matrix.
        static void PatternFirstMatrix()
        {
            int[,] firstMatrix = new int[n, n];

            int counter = 1;

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    firstMatrix[row, col] = counter;
                    counter++;
                }
            }

        // Print the matrix from the "PrintMatrix" method.
        PrintMatrix(firstMatrix);
        }

         // Pattern for second matrix.
        static void PatternSecondMatrix()
        {
            int[,] secondMatrix = new int[n, n];

            int counter = 1;

            for (int col = 0; col < n; col++)
            {
                if (col % 2 == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        secondMatrix[row, col] = counter;
                        counter++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        secondMatrix[row, col] = counter;
                        counter++;
                    }
                }
             }
            
            // Print the matrix from the "PrintMatrix" method.
            PrintMatrix(secondMatrix);
        }

        // Printing matrix method.
        static void PrintMatrix(int[,] matrix)
        {
            for (int a = 0; a < matrix.GetLength(0); a++)
            {
                for (int b = 0; b < matrix.GetLength(1); b++)
                {
                    Console.Write("{0} ", matrix[a, b]);
                }
                Console.WriteLine();
            }
        }
        
        // Main method.
        static void Main(string[] args)
        {
            Console.Write("Enter the number for rows and cols : ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("First pattern : \n");
            PatternFirstMatrix();
            Console.WriteLine();
            Console.Write("Second pattern : \n");
            PatternSecondMatrix();
        }
    }

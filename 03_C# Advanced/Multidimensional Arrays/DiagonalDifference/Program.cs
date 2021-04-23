using System;
using System.Linq;

namespace DiagonalDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowsCols, rowsCols];

            for (int row = 0; row < rowsCols; row++)
            {
                int[] currentLine = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < rowsCols; col++)
                {
                    matrix[row, col] = currentLine[col];
                }
            }

            int primeryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int row = 0; row < rowsCols; row++)
            {
                primeryDiagonal += matrix[row, row];
                secondaryDiagonal += matrix[row, rowsCols - 1 - row];
            }

            Console.WriteLine(Math.Abs(primeryDiagonal - secondaryDiagonal));
        }
    }
}


using System;
using System.Linq;

namespace SquareWithMaximumSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            int rows = input[0];
            int cols = input[1];
            int[,] matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                int[] line = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = line[col];
                }
            }

            int maxSum = 0;
            int rowToPrint = 0;
            int colToPrint = 0;

            for (int row = 0; row < rows; row++)
            {
                int currentSum = 0;

                for (int col = 0; col < cols; col++)
                {
                    if (row + 1 < rows && col + 1 < cols)
                    {
                        currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row, col + 1];

                        if (currentSum > maxSum)
                        {
                            maxSum = currentSum;
                            rowToPrint = row;
                            colToPrint = col;
                        }   
                    }   
                }
            }

            Console.WriteLine($"{matrix[rowToPrint, colToPrint]} {matrix[rowToPrint, colToPrint + 1]}");
            Console.WriteLine($"{matrix[rowToPrint +1, colToPrint]} {matrix[rowToPrint + 1, colToPrint + 1]}");
            Console.WriteLine(maxSum);
        }
    }
}

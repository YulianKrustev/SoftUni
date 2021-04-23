using System;
using System.Linq;

namespace MatrixShuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int rows = rowsCols[0];
            int cols = rowsCols[1];

            string[,] matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                string[] input = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            string command = Console.ReadLine();

            while (command != "END")
            {
                string[] tokens = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string swap = tokens[0];

                if (swap == "swap" && tokens.Length == 5 && int.Parse(tokens[1]) < rows && int.Parse(tokens[3]) < rows && int.Parse(tokens[2]) < cols && int.Parse(tokens[4]) < cols)
                {
                    int elementOneRow = int.Parse(tokens[1]);
                    int elementOneCol = int.Parse(tokens[2]);
                    int elementTwoRow = int.Parse(tokens[3]);
                    int elementTwoCol = int.Parse(tokens[4]);

                    string elementOneToSwap = matrix[elementOneRow, elementOneCol];
                    string elementTwoToSwap = matrix[elementTwoRow, elementTwoCol];

                    matrix[elementOneRow, elementOneCol] = elementTwoToSwap;
                    matrix[elementTwoRow, elementTwoCol] = elementOneToSwap;

                    for (int row = 0; row < rows; row++)
                    {
                        for (int col = 0; col < cols; col++)
                        {
                            Console.Write(matrix[row,col] + " ");
                        }

                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }

                command = Console.ReadLine();
            }
        }
    }
}

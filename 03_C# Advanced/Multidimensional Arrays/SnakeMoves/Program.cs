using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace SnakeMoves
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsCols = Console
                .ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int rows = rowsCols[0];
            int cols = rowsCols[1];

            char[,] matrix = new char[rows, cols];
            char[] snake = Console.ReadLine().ToCharArray();
            Queue input = new Queue(snake);
 
            for (int row = 0; row < rows; row++)
            {
                if (row % 2 == 0 || row == 0)
                {
                    for (int col = 0; col < cols; col++)
                    {
                        char current = char.Parse(input.Dequeue().ToString());
                        matrix[row, col] = current;
                        input.Enqueue(current);
                    }
                }
                else
                {
                    for (int col = cols - 1; col >= 0; col--)
                    {
                        char current = char.Parse(input.Dequeue().ToString());
                        matrix[row, col] = current;
                        input.Enqueue(current);
                    }
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}

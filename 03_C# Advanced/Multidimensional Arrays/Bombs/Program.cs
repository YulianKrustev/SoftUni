using System;
using System.Linq;

namespace Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            int[,] field = new int[fieldSize, fieldSize];

            for (int row = 0; row < fieldSize; row++)
            {
                int[] inputRow = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = inputRow[col];
                }
            }

            string[] bombs = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < bombs.Length; i++)
            {
                string[] location = bombs[i].Split(",").ToArray();
                int bombRow = int.Parse(location[0]);
                int bombCol = int.Parse(location[1]);
                int powerOfTheExplosion = field[bombRow, bombCol];

                if (powerOfTheExplosion > 0)
                {
                    if (bombCol - 1 >= 0 && field[bombRow, bombCol - 1] > 0)
                    {
                        field[bombRow, bombCol - 1] -= powerOfTheExplosion;
                    }

                    if (bombCol + 1 < fieldSize && field[bombRow, bombCol + 1] > 0)
                    {
                        field[bombRow, bombCol + 1] -= powerOfTheExplosion;
                    }

                    if (bombRow - 1 >= 0 && field[bombRow - 1, bombCol] > 0)
                    {
                        field[bombRow - 1, bombCol] -= powerOfTheExplosion;
                    }

                    if (bombRow + 1 < fieldSize && field[bombRow + 1, bombCol] > 0)
                    {
                        field[bombRow + 1, bombCol] -= powerOfTheExplosion;
                    }

                    if (bombRow - 1 >= 0 && bombCol - 1 >= 0 && field[bombRow - 1, bombCol - 1] > 0)
                    {
                        field[bombRow - 1, bombCol - 1] -= powerOfTheExplosion;
                    }

                    if (bombRow - 1 >= 0 && bombCol + 1 < fieldSize && field[bombRow - 1, bombCol + 1] > 0)
                    {
                        field[bombRow - 1, bombCol + 1] -= powerOfTheExplosion;
                    }

                    if (bombRow + 1 < fieldSize && bombCol - 1 >= 0 && field[bombRow + 1, bombCol - 1] > 0)
                    {
                        field[bombRow + 1, bombCol - 1] -= powerOfTheExplosion;
                    }

                    if (bombRow + 1 < fieldSize && bombCol + 1 < fieldSize && field[bombRow + 1, bombCol + 1] > 0)
                    {
                        field[bombRow + 1, bombCol + 1] -= powerOfTheExplosion;
                    }

                    field[bombRow, bombCol] = 0;
                }

                
            }

            int activeCells = 0;
            int sumOfActiveCells = 0;

            foreach (var cell in field)
            {
                if (cell > 0)
                {
                    activeCells++;
                    sumOfActiveCells += cell;
                }
            }

            Console.WriteLine($"Alive cells: {activeCells}");
            Console.WriteLine($"Sum: {sumOfActiveCells}");

            for (int row = 0; row < fieldSize; row++)
            {
                for (int col = 0; col < fieldSize; col++)
                {
                    Console.Write(field[row, col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}

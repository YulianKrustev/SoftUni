using System;
using System.Linq;

namespace Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());
            string[] commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] field = new char[fieldSize, fieldSize];
            int countCoals = 0;
            int allCoals = 0;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < fieldSize; row++)
            {
                char[] inputLine = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < fieldSize; col++)
                {
                    field[row, col] = inputLine[col];

                    if (field[row, col] == 'c')
                    {
                        allCoals++;
                    }
                    else if (field[row, col] == 's')
                    {
                        startRow = row;
                        startCol = col;
                    }
                }
            }

            for (int i = 0; i < commands.Length; i++)
            {
                string currCommand = commands[i];

                switch (currCommand)
                {
                    case "left":
                        if (startCol - 1 >= 0)
                        {
                            startCol = startCol - 1;

                            if (field[startRow, startCol] == 'c')
                            {
                                field[startRow, startCol] = '*';
                                countCoals++;
                            }
                            else if (field[startRow, startCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({startRow}, {startCol})");
                                return;
                            }
                        }
                        break;

                    case "right":
                        if (startCol + 1 < fieldSize)
                        {
                            startCol = startCol + 1;

                            if (field[startRow, startCol] == 'c')
                            {
                                field[startRow, startCol] = '*';
                                countCoals++;
                            }
                            else if (field[startRow, startCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({startRow}, {startCol})");
                                return;
                            }
                        }
                        break;

                    case "down":
                        if (startRow + 1 < fieldSize)
                        {
                            startRow = startRow + 1;

                            if (field[startRow, startCol] == 'c')
                            {
                                field[startRow, startCol] = '*';
                                countCoals++;
                            }
                            else if (field[startRow, startCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({startRow}, {startCol})");
                                return;
                            }
                        }
                        break;

                    case "up":
                        if (startRow - 1 >= 0)
                        {
                            startRow = startRow - 1;

                            if (field[startRow, startCol] == 'c')
                            {
                                field[startRow, startCol] = '*';
                                countCoals++;
                            }
                            else if (field[startRow, startCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({startRow}, {startCol})");
                                return;
                            }
                        }
                        break;
                }

                if (countCoals == allCoals)
                {
                    Console.WriteLine($"You collected all coals! ({startRow}, {startCol})");
                    return;
                }
            }

            Console.WriteLine($"{allCoals - countCoals} coals left. ({ startRow}, { startCol})");
        }
    }
}

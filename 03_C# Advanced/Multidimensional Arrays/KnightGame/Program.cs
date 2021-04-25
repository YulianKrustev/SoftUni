using System;
using System.Collections.Generic;
using System.Linq;

namespace KnightGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int sizeOfBoard = int.Parse(Console.ReadLine());
            char[,] board = new char[sizeOfBoard, sizeOfBoard];

            for (int row = 0; row < sizeOfBoard; row++)
            {
                char[] inputRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < sizeOfBoard; col++)
                {
                    board[row, col] = inputRow[col];
                }
            }

            Dictionary<string, int> database = new Dictionary<string, int>();
            bool onSiege = true;
            int counter = 0;

            while (onSiege)
            {
                for (int row = 0; row < sizeOfBoard; row++)
                {
                    for (int col = 0; col < sizeOfBoard; col++)
                    {
                        if (board[row, col] == 'K')
                        {
                            int counterKey = 0;
                            string position = $"{row} {col}";

                            if (row - 2 >= 0)
                            {
                                if (col - 1 >= 0 && board[row - 2, col - 1] == 'K')
                                {
                                    counterKey++;
                                }

                                if (col + 1 < sizeOfBoard && board[row - 2, col + 1] == 'K')
                                {
                                    counterKey++;
                                }
                            }

                            if (row + 2 < sizeOfBoard)
                            {
                                if (col - 1 >= 0 && board[row + 2, col - 1] == 'K')
                                {
                                    counterKey++;
                                }

                                if (col + 1 < sizeOfBoard && board[row + 2, col + 1] == 'K')
                                {
                                    counterKey++;
                                }
                            }

                            if (col - 2 >= 0)
                            {
                                if (row - 1 >= 0 && board[row - 1, col - 2] == 'K')
                                {
                                    counterKey++;
                                }

                                if (row + 1 < sizeOfBoard && board[row + 1, col - 2] == 'K')
                                {
                                    counterKey++;
                                }
                            }

                            if (col + 2 < sizeOfBoard)
                            {
                                if (row - 1 >= 0 && board[row - 1, col + 2] == 'K')
                                {
                                    counterKey++;
                                }

                                if (row + 1 < sizeOfBoard && board[row + 1, col + 2] == 'K')
                                {
                                    counterKey++;
                                }
                            }

                            if (counterKey > 0)
                            {
                                database.Add(position, counterKey);
                            }
                        }
                    }
                }

                if (database.Any())
                {
                    database = database.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
                    int[] elementToRemove = database.ElementAt(0).Key.Split().Select(int.Parse).ToArray();
                    board[elementToRemove[0], elementToRemove[1]] = '0';
                    counter++;
                    database = new Dictionary<string, int>();
                }
                else
                {
                    onSiege = false;
                }
                
            }

            Console.WriteLine(counter);
        }
    }
}

using System;

namespace Re_Volt
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int countOfCommmands = int.Parse(Console.ReadLine());
            int playerRow = 0;
            int playerCol = 0;

            char[][] matrix = new char[size][];

            for (int i = 0; i < size; i++)
            {
                string row = Console.ReadLine();
                matrix[i] = new char[row.Length];

                for (int j = 0; j < size; j++)
                {
                    matrix[i][j] = row[j];

                    if (row[j] == 'f')
                    {
                        playerRow = i;
                        playerCol = j;
                        matrix[playerRow][playerCol] = '-';
                    }
                }
            }

            for (int i = 0; i < countOfCommmands; i++)
            {
                string command = Console.ReadLine();

                if (command == "up")
                {
                    playerRow = MoveUpIsPossible(size, playerRow);

                    if (matrix[playerRow][playerCol] == 'B')
                    {
                        playerRow = MoveUpIsPossible(size, playerRow);
                    }
                    else if (matrix[playerRow][playerCol] == 'F')
                    {
                        PlayerWon(matrix, playerRow, playerCol);
                    }
                    else if (matrix[playerRow][playerCol] == 'T')
                    {
                        playerRow = playerRow + 1 < size == true ? playerRow + 1 : 0;
                    }
                }
                else if (command == "down")
                {
                    playerRow = MoveDownIsPossible(size, playerRow);

                    if (matrix[playerRow][playerCol] == 'B')
                    {
                        playerRow = MoveDownIsPossible(size, playerRow);
                    }
                    else if (matrix[playerRow][playerCol] == 'F')
                    {
                        PlayerWon(matrix, playerRow, playerCol);
                    }
                    else if (matrix[playerRow][playerCol] == 'T')
                    {
                        playerRow = playerRow < 0 == true ? playerRow - 1 : size - 1;
                    }
                }
                else if (command == "left")
                {
                    playerCol = MoveLeftIsPossible(size, playerCol);

                    if (matrix[playerRow][playerCol] == 'B')
                    {
                        playerCol = MoveLeftIsPossible(size, playerCol);
                    }
                    else if (matrix[playerRow][playerCol] == 'F')
                    {
                        PlayerWon(matrix, playerRow, playerCol);
                    }
                    else if (matrix[playerRow][playerCol] == 'T')
                    {
                        playerCol = playerCol + 1 < size == true ? playerCol + 1 : 0;
                    }
                }
                else if(command == "right")
                {
                    playerCol = MoveRightIsPossible(size, playerCol);

                    if (matrix[playerRow][playerCol] == 'B')
                    {
                        playerRow = MoveRightIsPossible(size, playerCol);
                    }
                    else if (matrix[playerRow][playerCol] == 'F')
                    {
                        PlayerWon(matrix, playerRow, playerCol);
                    }
                    else if (matrix[playerRow][playerCol] == 'T')
                    {
                        playerCol = playerCol > 0 == true ? playerCol - 1 : size - 1;
                    }
                }
            }

            Console.WriteLine("Player lost!");
            matrix[playerRow][playerCol] = 'f';
            Print(matrix);
        }

        private static void PlayerWon(char[][] matrix, int playerRow, int playerCol)
        {
            Console.WriteLine("Player won!");
            matrix[playerRow][playerCol] = 'f';
            Print(matrix);
        }

        private static void Print(char[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(row);
            }
            Environment.Exit(0);
        }

        private static int MoveRightIsPossible(int size, int playerCol)
        {
            return playerCol + 1 < size == true ? playerCol + 1 : 0;
        }

        private static int MoveLeftIsPossible(int size, int playerCol)
        {
            return playerCol > 0 == true ? playerCol - 1 : size - 1;
        }

        private static int MoveDownIsPossible(int size, int playerRow)
        {
            return playerRow + 1 < size  == true ? playerRow + 1 : 0;
        }

        private static int MoveUpIsPossible(int size, int playerRow)
        {
            return playerRow > 0 == true ? playerRow - 1 : size - 1;
        }
    }
}

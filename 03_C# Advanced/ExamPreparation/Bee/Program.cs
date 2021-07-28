using System;

namespace Bee
{
    class Program
    {
        static int size = int.Parse(Console.ReadLine());
        static char[][] beeField = new char[size][];
        static int beeRow = 0;
        static int beeCol = 0;
        static int popollinateFlowers = 0;

        static void Main(string[] args)
        {
            for (int row = 0; row < size; row++)
            {
                string input = Console.ReadLine();
                beeField[row] = new char[input.Length];

                for (int col = 0; col < size; col++)
                {
                    beeField[row][col] = input[col];

                    if (beeField[row][col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                        beeField[beeRow][beeCol] = '.';
                    }
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                switch (command)
                {
                    case "up":
                        if (beeRow - 1 < 0)
                        {
                            BeeIsLost();
                        }
                        else if (beeField[beeRow-1][beeCol] == 'f')
                        {
                            popollinateFlowers++;
                            beeRow--;
                            beeField[beeRow][beeCol] = '.';
                        }
                        else if (beeField[beeRow - 1][beeCol] == 'O')
                        {
                            beeRow--;
                            beeField[beeRow][beeCol] = '.';

                            if (beeRow - 1 < 0)
                            {
                                BeeIsLost();
                            }
                            else if (beeField[beeRow - 1][beeCol] == 'f')
                            {
                                popollinateFlowers++;
                                beeRow--;
                                beeField[beeRow][beeCol] = '.';
                            }
                        }
                        else
                        {
                            beeRow--;
                        }
                        break;
                    case "down":
                        if (beeRow + 1 == size)
                        {
                            BeeIsLost();
                        }
                        else if (beeField[beeRow + 1][beeCol] == 'f')
                        {
                            popollinateFlowers++;
                            beeRow++;
                            beeField[beeRow][beeCol] = '.';
                        }
                        else if (beeField[beeRow + 1][beeCol] == 'O')
                        {
                            beeRow++;
                            beeField[beeRow][beeCol] = '.';

                            if (beeRow + 1 == size)
                            {
                                BeeIsLost();
                            }
                            else if (beeField[beeRow + 1][beeCol] == 'f')
                            {
                                popollinateFlowers++;
                                beeRow++;
                                beeField[beeRow][beeCol] = '.';
                            }
                        }
                        else
                        {
                            beeRow++;
                        }
                        break;
                    case "left":
                        if (beeCol - 1 < 0)
                        {
                            BeeIsLost();
                        }
                        else if (beeField[beeRow][beeCol - 1] == 'f')
                        {
                            popollinateFlowers++;
                            beeCol--;
                            beeField[beeRow][beeCol] = '.';
                        }
                        else if (beeField[beeRow][beeCol - 1] == 'O')
                        {
                            beeCol--;
                            beeField[beeRow][beeCol] = '.';

                            if (beeCol - 1 < 0)
                            {
                                BeeIsLost();
                            }
                            else if (beeField[beeRow][beeCol - 1] == 'f')
                            {
                                popollinateFlowers++;
                                beeCol--;
                                beeField[beeRow][beeCol] = '.';
                            }
                        }
                        else
                        {
                            beeCol--;
                        }
                        break;
                    case "right":
                        if (beeCol + 1 == size)
                        {
                            BeeIsLost();
                        }
                        else if (beeField[beeRow][beeCol + 1] == 'f')
                        {
                            popollinateFlowers++;
                            beeCol++;
                            beeField[beeRow][beeCol] = '.';
                        }
                        else if (beeField[beeRow][beeCol + 1] == 'O')
                        {
                            beeCol++;
                            beeField[beeRow][beeCol] = '.';

                            if (beeCol + 1 ==size)
                            {
                                BeeIsLost();
                            }
                            else if (beeField[beeRow][beeCol + 1] == 'f')
                            {
                                popollinateFlowers++;
                                beeCol++;
                                beeField[beeRow][beeCol] = '.';
                            }
                        }
                        else
                        {
                            beeCol++;
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            beeField[beeRow][beeCol] = 'B';
            if (popollinateFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - popollinateFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {popollinateFlowers} flowers!");
            }

            foreach (var row in beeField)
            {
                Console.WriteLine(row);
            }
        }

        private static void BeeIsLost()
        {
            beeField[beeRow][beeCol] = '.';
            Console.WriteLine("The bee got lost!");

            if (popollinateFlowers < 5)
            {
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {5 - popollinateFlowers} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {popollinateFlowers} flowers!");
            }

            foreach (var row in beeField)
            {
                Console.WriteLine(row);
            }

            Environment.Exit(0);
        }
    }
}

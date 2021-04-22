using System;

namespace PascalTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            long[][] array = new long[rows][];


            for (int row = 0; row < rows; row++)
            {

                array[row] = new long[row + 1];

                for (int col = 0; col < row + 1; col++)
                {
                    if (row - 1 >= 0 && col - 1 >= 0 && col < row)
                    {
                        array[row][col] = array[row - 1][col - 1] + array[row - 1][col];
                    }
                    else
                    {
                        array[row][col] = 1;
                    }
                     
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < row + 1; col++)
                {
                    Console.Write(array[row][col] + " ");
                }
                Console.WriteLine();
            }

        }
    }
}

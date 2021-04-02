using System;

namespace NxN_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            PrintMatrix(number);
        }

        private static void PrintMatrix(int number)
        {
            int[] matrix = new int[number];
            int count = 0;

            for (int i = 0; i < number; i++)
            {
                matrix[i] = number;
            }

            while (count < number)
            {
                Console.WriteLine(string.Join(" ", matrix));
                count++;
            }
        }
    }
}

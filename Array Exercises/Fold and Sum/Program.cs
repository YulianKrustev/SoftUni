using System;
using System.Linq;

namespace Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputNumbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToArray();

            for (int i = 0; i < inputNumbers.Length / 4; i++)
            {
                Console.Write(inputNumbers[(inputNumbers.Length / 4) + i] + inputNumbers[(inputNumbers.Length / 4) - 1 - i] + " ");
                
            }

            for (int i = 0; i < inputNumbers.Length / 4; i++)
            {
                Console.Write(inputNumbers[(inputNumbers.Length / 2) + i] + inputNumbers[(inputNumbers.Length - 1) - i] + " ");
            }
            
        }
    }
}

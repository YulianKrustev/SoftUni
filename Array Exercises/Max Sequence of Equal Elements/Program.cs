using System;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int equal = 0;
            int current = 0;
            int maxEqual = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    equal++;
                }
                else
                {
                    equal = 0;
                }
                if (equal > maxEqual)
                {
                    maxEqual = equal;
                    current = numbers[i];
                }
            }
            for (int i = 0; i < maxEqual + 1; i++)
            {
                Console.Write(current + " ");
            }

        }
    }
}

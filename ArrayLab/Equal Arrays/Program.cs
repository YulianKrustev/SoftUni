using System;
using System.Linq;

namespace Equal_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] numsTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int diffIndex = 0;
            int sum = 0;
            bool diffArr = false;

            for (int i = 0; i < numsOne.Length; i++)
            {
                if (numsOne[i] != numsTwo[i])
                {
                    diffIndex = i;
                    diffArr = true;
                    break;
                }
                else
                {
                    sum += numsTwo[i];
                }
            }

            if (diffArr)
            {
                Console.WriteLine($"Arrays are not identical. Found difference at {diffIndex} index");
            }
            else
            {
                Console.WriteLine($"Arrays are identical. Sum: {sum}");
            }
        }
    }
}

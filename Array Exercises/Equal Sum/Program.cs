using System;
using System.Linq;

namespace Equal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();

            if (numbers.Length == 1)
            {
                Console.WriteLine("0");
                return;
            }

            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                leftSum += numbers[i];
                rightSum = 0;
                for (int j = i + 2; j < numbers.Length; j++)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i + 1);
                    break;
                }
            }
            if (leftSum != rightSum)
            {
                Console.WriteLine("no");
            }
        }
    }
}

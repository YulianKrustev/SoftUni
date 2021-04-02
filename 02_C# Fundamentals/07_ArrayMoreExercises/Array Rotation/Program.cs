using System;
using System.Linq;

namespace Array_Rotation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
            int reveseNum = int.Parse(Console.ReadLine());
            

            for (int i = 0; i < reveseNum; i++)
            {
                int[] newNumbers = new int[numbers.Length];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (j == numbers.Length - 1)
                    {
                        newNumbers[numbers.Length - 1] = numbers[0];
                    }
                    else
                    {
                        newNumbers[j] = numbers[j + 1];
                    }

                }

                numbers = newNumbers;
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

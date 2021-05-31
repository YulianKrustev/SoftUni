using System;
using System.Linq;

namespace CustomMinFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> MinNumber = numbers =>
            {
                int minNumber = int.MaxValue;

                foreach (var number in numbers)
                {
                    if (number < minNumber)
                    {
                        minNumber = number;
                    }
                }

                return minNumber;
            };

            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int result = MinNumber(numbers);
            Console.WriteLine(result);

        }
    }
}

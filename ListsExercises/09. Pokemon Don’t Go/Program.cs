using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            List<int> final = new List<int>();

            while (numbers.Count != 0)
            {
                int current = int.Parse(Console.ReadLine());

                if (current < 0)
                {
                    final.Add(numbers[0]);
                    numbers[0] = numbers[numbers.Count - 1];
                    numbers = UpdateNumber(numbers, final);
                }
                else if (current >= numbers.Count)
                {
                    final.Add(numbers[numbers.Count - 1]);
                    numbers[numbers.Count - 1] = numbers[0];
                    numbers = UpdateNumber(numbers, final);
                }
                else
                {
                    final.Add(numbers[current]);
                    numbers.RemoveAt(current);
                    numbers = UpdateNumber(numbers, final);
                }
            }
            Console.WriteLine(final.Sum());
        }

        private static List<int> UpdateNumber(List<int> numbers, List<int> final)
        {
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] <= final[final.Count - 1])
                {
                    numbers[i] += final[final.Count - 1];
                }
                else
                {
                    numbers[i] -= final[final.Count - 1];
                }
            }

            return numbers;
        }
    }
}

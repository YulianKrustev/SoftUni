using System;
using System.Collections.Generic;
using System.Linq;

namespace ListOfPredicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int range = int.Parse(Console.ReadLine());

            int[] dividers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .Distinct()
                .ToArray();

            List<int> numbers = new List<int>();
            Func<int, int, bool> checker = (x, y) => x % y != 0;

            for (int i = 1; i <= range; i++)
            {
                bool isValid = true;

                foreach (var number in dividers)
                {
                    if (checker(i, number))
                    {
                        isValid = false;
                    }
                }

                if (isValid == true)
                {
                    numbers.Add(i);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

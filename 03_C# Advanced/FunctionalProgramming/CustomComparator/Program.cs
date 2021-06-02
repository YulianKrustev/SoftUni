using System;
using System.Linq;

namespace CustomComparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Func<int, int, int> comparator = (a, b) =>
            (a % 2 == 0 && b % 2 != 0) ? -1 :
            (a % 2 != 0 && b % 2 == 0) ? 1 :
            a.CompareTo(b);

            Array.Sort(numbers, new Comparison<int>(comparator));

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

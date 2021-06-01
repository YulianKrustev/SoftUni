using System;
using System.Linq;

namespace ReverseAndExclude
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int divisor = int.Parse(Console.ReadLine());

            Func<int, bool> dividingFunc = x => x % divisor != 0;

            numbers = numbers.Where(dividingFunc).Reverse().ToArray();
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

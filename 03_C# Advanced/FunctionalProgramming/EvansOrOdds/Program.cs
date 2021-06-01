using System;
using System.Collections.Generic;
using System.Linq;

namespace EvansOrOdds
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine();
            Predicate<int> evenOrOdd = n => n % 2 == 0;
            List<int> numbers = Enumerable.Range(range[0], range[1] - range[0] + 1).ToList();
            

            if (command == "even")
            {
                numbers.RemoveAll(x => !evenOrOdd(x));
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                numbers.RemoveAll(evenOrOdd);
                Console.WriteLine(string.Join(" ", numbers));
            }
        }
    }
}

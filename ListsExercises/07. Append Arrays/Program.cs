using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Append_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbers = Console.ReadLine()
                                          .Split("|")
                                          .Reverse()
                                          .ToList();

            List<string> result = new List<string>();

            foreach (var item in numbers)
            {
                string[] current = item.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                foreach (var number in current)
                {
                    result.Add(number);
                }
            }

            Console.WriteLine(string.Join(" ", result));
        }
    }
}

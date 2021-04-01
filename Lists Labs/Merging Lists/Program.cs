using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersOne = Console.ReadLine()
                                          .Split()
                                          .Select(int.Parse)
                                          .ToList();
            List<int> numbersTwo = Console.ReadLine()
                                          .Split()
                                          .Select(int.Parse)
                                          .ToList();

            bool isBigger = numbersOne.Count >= numbersTwo.Count;
            List<int> numbersResult = new List<int>();

            for (int i = 0; i < Math.Min(numbersOne.Count, numbersTwo.Count); i++)
            {
                numbersResult.Add(numbersOne[i]);
                numbersResult.Add(numbersTwo[i]);
            }

            for (int i = Math.Min(numbersOne.Count, numbersTwo.Count); i < Math.Max(numbersOne.Count, numbersTwo.Count); i++)
            {
                if (i >= numbersOne.Count)
                {
                    numbersResult.Add(numbersTwo[i]);
                }
                else
                {
                    numbersResult.Add(numbersOne[i]);
                }
            }
            Console.WriteLine(string.Join(" ", numbersResult));
        }
    }
}

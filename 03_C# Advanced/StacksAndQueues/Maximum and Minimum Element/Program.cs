﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int[] tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (tokens[0] == 1)
                {
                    numbers.Push(tokens[1]);
                }
                else if (tokens[0] == 2)
                {
                    numbers.Pop();
                }
                else if (tokens[0] == 3 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Max());
                }
                else if (tokens[0] == 4 && numbers.Count > 0)
                {
                    Console.WriteLine(numbers.Min());
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace AssociativeArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();
            SortedDictionary<double, int> counts = new SortedDictionary<double, int>();

            for (int i = 0; i < numbers.Length; i++)
            {
                if (counts.ContainsKey(numbers[i]))
                {
                    counts[numbers[i]]++;
                }
                else
                {
                    counts.Add(numbers[i], 1);
                }
            }

            foreach (var item in counts)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
            
        }
    }
}

using System;
using System.Collections.Generic;

namespace CountSameValuesInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Dictionary<string, int> databaase = new Dictionary<string, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (!databaase.ContainsKey(input[i]))
                {
                    databaase.Add(input[i], 0);
                }

                databaase[input[i]]++;
            }

            foreach (var item in databaase)
            {
                Console.WriteLine($"{item.Key} - {item.Value} times");
            }
        }
    }
}

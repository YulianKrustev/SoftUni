using System;
using System.Collections.Generic;

namespace CountSymbols
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            SortedDictionary<char, int> database = new SortedDictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (database.ContainsKey(input[i]) == false)
                {
                    database.Add(input[i], 0);
                }

                database[input[i]]++;
            }

            foreach (var symbol in database)
            {
                Console.WriteLine($"{symbol.Key}: {symbol.Value} time/s");
            }
        }
    }
}

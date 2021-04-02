using System;
using System.Collections.Generic;
using System.Linq;

namespace More_Exercises_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                        .Split()
                                        .Select(int.Parse)
                                        .ToList();

            string input = Console.ReadLine();
            string output = string.Empty;           

            for (int i = 0; i < numbers.Count; i++)
            {
                int index = 0;

                for (int j = 0; j < numbers[i].ToString().Length; j++)
                {
                    string current = numbers[i].ToString();
                    index += int.Parse(current[j].ToString());
                }

                while (index >= input.Length)
                {
                    index -= input.Length;
                }

                output += input[index];
                input = input.Remove(index, 1);
            }

            Console.WriteLine(output);
        }
    }
}

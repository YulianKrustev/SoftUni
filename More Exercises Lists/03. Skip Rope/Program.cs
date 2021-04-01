using System;
using System.Collections.Generic;

namespace _03._Skip_Rope
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (int.TryParse(input[i].ToString(), out _))
                {
                    numbers.Add(int.Parse(input[i].ToString()));
                    input = input.Remove(i, 1);
                    i--;
                }
            }

            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    takeList.Add(numbers[i]);
                }
                else
                {
                    skipList.Add(numbers[i]);
                }
            }

            int counter = 0;
            string encrypted = string.Empty;
            for (int j = 0; j < takeList.Count; j++)
            {
                for (int i = 0; i < takeList[j]; i++)
                {
                    encrypted += input[counter];
                    counter++;
                }
                counter += skipList[j];
            }
            Console.WriteLine(encrypted);
        }
    }
}

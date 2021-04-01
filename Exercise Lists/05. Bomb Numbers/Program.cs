using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string[] command = Console.ReadLine().Split();

            while (numbers.Contains(int.Parse(command[0])))
            {
                int bombIndex = numbers.FindIndex(n => n == int.Parse(command[0]));
                int validIndex = 0;

                for (int i = bombIndex + 1; i < numbers.Count; i++)
                {
                    if (validIndex == int.Parse(command[1]))
                    {
                        break;
                    }
                    validIndex++;
                }

                int leftIndex = 0;

                for (int i = bombIndex - 1; i > -1; i--)
                {
                    if (leftIndex == int.Parse(command[1]))
                    {
                        break;
                    }
                    leftIndex++;
                }

                numbers.RemoveRange(bombIndex - leftIndex, leftIndex + validIndex + 1);
            }
                    
            Console.WriteLine(numbers.Sum());
        }
    }
}

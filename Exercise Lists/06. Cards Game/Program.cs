using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstHandCards = Console.ReadLine()
                                              .Split()
                                              .Select(int.Parse)
                                              .ToList();

            List<int> secondHandCards = Console.ReadLine()
                                              .Split()
                                              .Select(int.Parse)
                                              .ToList();


            while (firstHandCards.Count != 0 && secondHandCards.Count != 0)
            {
                if (firstHandCards[0] > secondHandCards[0])
                {
                    firstHandCards.Add(firstHandCards[0]);
                    firstHandCards.Add(secondHandCards[0]);
                }
                else if (secondHandCards[0] > firstHandCards[0])
                {
                    secondHandCards.Add(secondHandCards[0]);
                    secondHandCards.Add(firstHandCards[0]);
                }
                    firstHandCards.RemoveAt(0);
                    secondHandCards.RemoveAt(0);
            }

            if (firstHandCards.Count > secondHandCards.Count)
            {
                Console.WriteLine($"First player wins! Sum: {firstHandCards.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {secondHandCards.Sum()}");
            }
        }
    }
}

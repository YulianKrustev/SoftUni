using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lootBoxOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> lootBoxTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int points = 0;
            int i1 = 0;
            int i2 = lootBoxTwo.Count - 1;

            while (lootBoxOne.Count > 0 && lootBoxTwo.Count > 0)
            {
                int firstElement = lootBoxOne[i1];
                int secondElement = lootBoxTwo[i2];

                int sum = firstElement + secondElement;

                if (sum % 2 == 0)
                {
                    points += sum;

                    lootBoxOne.RemoveAt(0);
                    lootBoxTwo.RemoveAt(lootBoxTwo.Count - 1);
                }
                else
                {
                    lootBoxTwo.RemoveAt(lootBoxTwo.Count - 1);
                    lootBoxOne.Add(secondElement);
                }

                i2 = lootBoxTwo.Count - 1;
            }

            if (lootBoxOne.Count == 0)
            {
                Console.WriteLine("First lootbox is empty");

                CheckPoints(points);
            }
            else
            {
                Console.WriteLine("Second lootbox is empty");

                CheckPoints(points);
            }
        }

        private static void CheckPoints(int points)
        {
            if (points < 100)
            {
                Console.WriteLine($"Your loot was poor... Value: {points}");
            }
            else
            {
                Console.WriteLine($"Your loot was epic! Value: {points}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> lootBoxOne = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            Stack<int> lootBoxTwo = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int points = 0;

            while (lootBoxOne.Count > 0 && lootBoxTwo.Count > 0)
            {
                int firstElement = lootBoxOne.Peek();
                int secondElement = lootBoxTwo.Pop();

                int sum = firstElement + secondElement;

                if (sum % 2 == 0)
                {
                    points += sum;
                    lootBoxOne.Dequeue();
                }
                else
                {
                    lootBoxOne.Enqueue(secondElement);
                }
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

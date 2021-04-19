using System;
using System.Collections.Generic;
using System.Linq;

namespace Cups_and_bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] cups = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int[] filledBottles = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            Queue<int> cupsList = new Queue<int>(cups);
            Stack<int> bottlesList = new Stack<int>(filledBottles);
            int weastedWater = 0;

            while (cupsList.Any() && bottlesList.Any())
            {
                int currentCup = cupsList.Dequeue();
                int currentBottle = bottlesList.Pop();

                while (currentCup > currentBottle)
                {
                    currentCup -= currentBottle;
                    currentBottle = bottlesList.Pop();

                    if (currentCup < 0)
                    {
                        weastedWater -= currentCup;
                    }
                }

                if (currentBottle >= currentCup)
                {
                    weastedWater += currentBottle - currentCup;
                }
            }

            if (cupsList.Any())
            {
                Console.WriteLine($"Cups: {string.Join(" ", cupsList)}");
                Console.WriteLine($"Wasted litters of water: {weastedWater}");
            }
            else
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottlesList)}");
                Console.WriteLine($"Wasted litters of water: {weastedWater}");
            }
            

        }
    }
}

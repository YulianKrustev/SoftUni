using System;
using System.Collections.Generic;
using System.Linq;

namespace FlowerWreaths
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> lilies = new Stack<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            Queue<int> roses = new Queue<int>(Console.ReadLine().Split(", ").Select(int.Parse).ToArray());
            int storedFlowers = 0;
            int wreaths = 0;

            while (lilies.Count > 0 && roses.Count > 0)
            {
                int currentFlowers = lilies.Pop() + roses.Dequeue();

                if (currentFlowers == 15)
                {
                    wreaths++;
                }
                else if (currentFlowers < 15)
                {
                    storedFlowers += currentFlowers;
                }
                else
                {
                    while (currentFlowers > 15)
                    {
                        currentFlowers -= 2;
                    }

                    if (currentFlowers == 15)
                    {
                        wreaths++;
                    }
                    else
                    {
                        storedFlowers += currentFlowers;
                    }
                }
            }

            if (storedFlowers > 14 )
            {
                wreaths += storedFlowers / 15; 
            }

            if (wreaths >= 5)
            {
                Console.WriteLine($"You made it, you are going to the competition with {wreaths} wreaths!");
            }
            else
            {
                Console.WriteLine($"You didn't make it, you need {5-wreaths} wreaths more!");
            }
        }
    }
}

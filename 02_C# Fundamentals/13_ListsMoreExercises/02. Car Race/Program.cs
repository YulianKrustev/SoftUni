using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Car_Race
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToList();

            int timeBeforeFinish = input.Count / 2;
            double firstTime = 0;
            double secondTime = 0;

            for (int i = 0; i < timeBeforeFinish; i++)
            {
                if (input[i] == 0)
                {
                    firstTime *= 0.8;
                }
                firstTime += input[i];
            }

            for (int i = input.Count - 1; i > timeBeforeFinish; i--)
            {
                if (input[i] == 0)
                {
                    secondTime *= 0.8;
                }
                secondTime += input[i];
            }               

            if (secondTime >= firstTime)
            {

                Console.WriteLine($"The winner is left with total time: {firstTime}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {secondTime}");
            }
        }
    }
}

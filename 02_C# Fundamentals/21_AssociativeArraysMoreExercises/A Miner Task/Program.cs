using System;
using System.Collections.Generic;

namespace A_Miner_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> minedResurces = new Dictionary<string, int>();

            while(input != "stop")
            {
                int quantitiy = int.Parse(Console.ReadLine());

                if (minedResurces.ContainsKey(input))
                {
                    minedResurces[input] += quantitiy;
                }
                else
                {
                    minedResurces.Add(input, quantitiy);
                }

                input = Console.ReadLine();
            }

            foreach (var resurse in minedResurces)
            {
                Console.WriteLine($"{resurse.Key} -> {resurse.Value}");
            }
        }
    }
}

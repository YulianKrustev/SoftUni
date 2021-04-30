using System;
using System.Collections.Generic;

namespace Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int colorsCount = int.Parse(Console.ReadLine());
            var database = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < colorsCount; i++)
            {
                string[] tokens = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                string color = tokens[0];
                string[] clothes = tokens[1].Split(",", StringSplitOptions.RemoveEmptyEntries);

                if (database.ContainsKey(color) == false)
                {
                    database.Add(color, new Dictionary<string, int>());
                }

                for (int j = 0; j < clothes.Length; j++)
                {

                    if (database[color].ContainsKey(clothes[j]) == false)
                    {
                        database[color].Add(clothes[j], 0);
                    }

                    database[color][clothes[j]]++;
                }
            }

            string[] searchingItem = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string searchingColor = searchingItem[0];
            string searchingGarment = searchingItem[1];

            foreach (var color in database)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var item in color.Value)
                {
                    if (color.Key == searchingColor && item.Key == searchingGarment)
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {item.Key} - {item.Value}");
                    }                    
                }
            }
        }
    }
}

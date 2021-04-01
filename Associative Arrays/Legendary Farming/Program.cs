using System;
using System.Collections.Generic;
using System.Linq;

namespace Legendary_Farming
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().ToLower().Split();
            SortedDictionary<string, int> resurces = new SortedDictionary<string, int>();
            Dictionary<string, int> specialResurces = new Dictionary<string, int>();
            string item = string.Empty;
            specialResurces.Add("shards", 0);
            specialResurces.Add("fragments", 0);
            specialResurces.Add("motes", 0);
            bool isFound = false;

            for (int i = 0; i < input.Length; i += 2)
            {
                if (input[i + 1] == "shards" || input[i + 1] == "fragments" || input[i + 1] == "motes")
                {
                    if (specialResurces.ContainsKey(input[i + 1]))
                    {
                        specialResurces[input[i + 1]] += int.Parse(input[i]);
                    }
                    else
                    {
                        specialResurces.Add(input[i + 1], int.Parse(input[i]));
                    }
                }
                else
                {
                    if (resurces.ContainsKey(input[i + 1]))
                    {
                        resurces[input[i + 1]] += int.Parse(input[i]);
                    }
                    else
                    {
                        resurces.Add(input[i + 1], int.Parse(input[i]));
                    }
                }

                if (specialResurces["shards"] >= 250 || specialResurces["fragments"] >= 250 || specialResurces["motes"] >= 250)
                {
                    switch (input[i + 1])
                    {
                        case "shards":
                            item = "Shadowmourne";
                            specialResurces["shards"] -= 250;
                            isFound = true;
                            break;

                        case "fragments":
                            item = "Valanyr";
                            specialResurces["fragments"] -= 250;
                            isFound = true;
                            break;

                        case "motes":
                            item = "Dragonwrath";
                            specialResurces["motes"] -= 250;
                            isFound = true;
                            break;
                    }

                }
                if (isFound)
                {
                    break;
                }
                if (i == input.Length - 2)
                {
                    input = Console.ReadLine().ToLower().Split();
                    i = -2;
                }

            }

            specialResurces = specialResurces.OrderByDescending(x => x.Value).ThenBy(x=> x.Key).ToDictionary(x => x.Key, x => x.Value);
           

            Console.WriteLine($"{item} obtained!");

            foreach (var resurce in specialResurces)
            {
                Console.WriteLine($"{resurce.Key}: {resurce.Value}");
            }

            foreach (var bah in resurces)
            {
                Console.WriteLine($"{bah.Key}: {bah.Value}");
            }
        }
    }
}

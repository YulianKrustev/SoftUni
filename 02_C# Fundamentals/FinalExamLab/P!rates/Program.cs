using System;
using System.Collections.Generic;
using System.Linq;

namespace P_rates
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> cities = new Dictionary<string, List<int>>();

            while (input != "Sail")
            {
                string[] info = input.Split("||", StringSplitOptions.RemoveEmptyEntries);
              
                if(cities.ContainsKey(info[0]))
                {
                    cities[info[0]][0] += int.Parse(info[1]);
                    cities[info[0]][1] += int.Parse(info[2]);
                }
                else
                {
                    cities.Add(info[0], new List<int>());
                    cities[info[0]].Add(int.Parse(info[1]));
                    cities[info[0]].Add(int.Parse(info[2]));
                }

                input = Console.ReadLine();
            }

            string events = Console.ReadLine();

            while (events != "End")
            {
                string[] command = events.Split("=>");

                if (command[0] == "Plunder")
                {
                    cities[command[1]][0] -= int.Parse(command[2]);
                    cities[command[1]][1] -= int.Parse(command[3]);
                    Console.WriteLine($"{command[1]} plundered! {command[3]} gold stolen, {command[2]} citizens killed.");

                    if (cities[command[1]][0] <= 0 || cities[command[1]][1] <= 0)
                    {
                        cities.Remove(command[1]);
                        Console.WriteLine($"{command[1]} has been wiped off the map!");

                    }
                }
                else if (command[0] == "Prosper")
                {
                    if (int.Parse(command[2]) > 0)
                    {
                        cities[command[1]][1] += int.Parse(command[2]);
                        Console.WriteLine($"{command[2]} gold added to the city treasury. {command[1]} now has {cities[command[1]][1]} gold.");
                    }
                    else
                    {
                        Console.WriteLine("Gold added cannot be a negative number!");
                    }
                }

                events = Console.ReadLine();
            }

            if (cities.Count == 0)
            {
                Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
            }
            else
            {
                Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
                foreach (var city in cities.OrderByDescending(x=>x.Value[1]).ThenBy(x => x.Key))
                {
                    Console.WriteLine($"{city.Key} -> Population: {city.Value[0]} citizens, Gold: {city.Value[1]} kg");
                }
            }
        }
    }
}

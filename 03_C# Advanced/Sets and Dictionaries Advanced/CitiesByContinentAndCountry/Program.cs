using System;
using System.Collections.Generic;

namespace CitiesByContinentAndCountry
{
    class Program
    {
        static void Main(string[] args)
        {
            int continents = int.Parse(Console.ReadLine());

            var database = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < continents; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (database.ContainsKey(continent) == false)
                {
                    database.Add(continent, new Dictionary<string, List<string>>());
                }

                if (database[continent].ContainsKey(country) == false)
                {
                    database[continent].Add(country, new List<string>());
                }

                database[continent][country].Add(city);
            }

            foreach (var continent in database)
            {
                Console.WriteLine($"{continent.Key}:");

                foreach (var country in continent.Value)
                {
                    Console.WriteLine($"{country.Key} -> {string.Join(", ", country.Value)}");
                }
            }
        }
    }
}

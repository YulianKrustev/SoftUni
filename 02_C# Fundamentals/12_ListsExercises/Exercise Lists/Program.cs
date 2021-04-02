using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfWagons = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToList();

            int maxCapacity = int.Parse(Console.ReadLine());
            string[] passengers = Console.ReadLine().Split();

            while(passengers[0].ToLower() != "end")
            {
                if (passengers[0].ToLower() == "add")
                {
                    listOfWagons.Add(int.Parse(passengers[1]));
                }
                else
                {
                    for (int i = 0; i < listOfWagons.Count; i++)
                    {
                        if (listOfWagons[i] + int.Parse(passengers[0]) <= maxCapacity)
                        {
                            listOfWagons[i] += int.Parse(passengers[0]);
                            break;
                        }
                    }
                }
                passengers = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", listOfWagons));
        }
    }
}

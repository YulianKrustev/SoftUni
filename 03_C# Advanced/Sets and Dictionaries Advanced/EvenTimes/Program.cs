using System;
using System.Collections.Generic;

namespace EvenTimes
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNumber = int.Parse(Console.ReadLine());

            Dictionary<int, int> database = new Dictionary<int, int>();


            for (int i = 0; i < countNumber; i++)
            {
                int current = int.Parse(Console.ReadLine());

                if (!database.ContainsKey(current))
                {
                    database.Add(current, 0);
                }

                database[current]++;
            }

            foreach (var item in database)
            {
                if (item.Value % 2 == 0)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
    }
}

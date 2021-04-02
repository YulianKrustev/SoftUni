using System;
using System.Collections.Generic;
using System.Linq;

namespace Judge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, int>> database = new Dictionary<string, Dictionary<string, int>>();
            Dictionary<string, int> results = new Dictionary<string, int>();

            while (input != "no more time")
            {
                string[] data = input.Split(" -> ");
                string username = data[0];
                string course = data[1];
                int points = int.Parse(data[2]);
                bool changeIt = true;

                if (database.ContainsKey(course) == false)
                {
                    database.Add(course, new Dictionary<string, int>());
                    database[course].Add(username, points);

                }
                else if (database[course].ContainsKey(username))
                {
                    changeIt = false;
                    if (database[course][username] < points)
                    {
                        changeIt = false;
                        results[username] += points - database[course][username];
                        database[course][username] = points;
                    }
                    
                }
                else if(database[course].ContainsKey(username) == false)
                {
                    database[course].Add(username, points);
                }

                if (results.ContainsKey(username) == false)
                {
                    results.Add(username, points);
                }
                else if (changeIt)
                {
                    results[username] += points;
                }

                input = Console.ReadLine();
                changeIt = false;
            }

            foreach (var course in database)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Keys.Count} participants");
                int counter = 0;

                foreach (var student in course.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                {
                    counter++;
                    Console.WriteLine($"{counter}. {student.Key} <::> {student.Value}");
                }
            }

            Console.WriteLine("Individual standings:");
            int counter1 = 0;
            foreach (var student in results.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                counter1++;
                Console.WriteLine($"{counter1}. {student.Key} -> {student.Value}");
            }
        }
    }
}

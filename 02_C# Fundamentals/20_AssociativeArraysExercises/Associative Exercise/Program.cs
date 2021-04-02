using System;
using System.Collections.Generic;
using System.Linq;

namespace Associative_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, string> courses = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                string[] data = input.Split(":");
                string couse = data[0];
                string password = data[1];

                courses.Add(couse, password);

                input = Console.ReadLine();
            }

            string points = Console.ReadLine();
            SortedDictionary<string, Dictionary<string, int>> databases = new SortedDictionary<string, Dictionary<string, int>>();

            while (points != "end of submissions")
            {
                string[] data = points.Split("=>");
                string course = data[0];
                string password = data[1];
                string username = data[2];
                int userPoints = int.Parse(data[3]);

                if (courses.ContainsKey(course) && courses[course] == password)
                {
                    if (databases.ContainsKey(username))
                    {
                        if (databases[username].ContainsKey(course) && databases[username][course] < userPoints)
                        {
                            databases[username][course] = userPoints;
                        }
                        else if (databases[username].ContainsKey(course) == false)
                        {
                            databases[username].Add(course, userPoints);
                        }                       
                    }
                    else
                    {
                        databases.Add(username, new Dictionary<string, int>());
                        databases[username].Add(course, userPoints);
                    }                 
                }

                points = Console.ReadLine();
            }

            Dictionary<string, int> totalPoints = new Dictionary<string, int>();

            foreach (var item in databases)
            {
                totalPoints.Add(item.Key, item.Value.Values.Sum());
            }

            Console.WriteLine($"Best candidate is {totalPoints.Keys.Max()} with total {totalPoints.Values.Max()} points.");
            Console.WriteLine("Ranking: ");

            foreach (var student in databases)
            {
                Console.WriteLine($"{student.Key}");

                foreach (var item in student.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {item.Key} -> {item.Value}");
                }
            }


        }
    }
}

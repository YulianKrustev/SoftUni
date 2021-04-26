using System;
using System.Collections.Generic;
using System.Linq;

namespace AverageStudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            int grades = int.Parse(Console.ReadLine());
            Dictionary<string, List<decimal>> database = new Dictionary<string, List<decimal>>();

            for (int i = 0; i < grades; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = input[0];
                decimal grade = decimal.Parse(input[1]);

                if (database.ContainsKey(name) == false)
                {
                    database.Add(name, new List<decimal>());
                }

                database[name].Add(grade);
            }

            foreach (var student in database)
            {
                Console.WriteLine($"{student.Key} -> {string.Join(" ", student.Value)} (avg: {student.Value.Average():f2})");
            }
        }
    }
}

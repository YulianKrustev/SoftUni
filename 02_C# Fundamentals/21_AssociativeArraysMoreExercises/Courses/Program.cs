using System;
using System.Collections.Generic;
using System.Linq;

namespace Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while (input != "end")
            {
                string[] data = input.Split(" : ");
                string courseName = data[0];
                string student = data[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(student);
                }
                else
                {
                    courses.Add(courseName, new List<string> { student });
                }

                input = Console.ReadLine();
            }

            foreach (var course in courses.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach (var item in course.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {item}");
                }
            }
        }
    }
}

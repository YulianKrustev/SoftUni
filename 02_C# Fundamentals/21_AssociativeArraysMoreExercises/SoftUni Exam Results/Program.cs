using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            SortedDictionary<string, int> examCounter = new SortedDictionary<string, int>();
            SortedDictionary<string, int> studentsData = new SortedDictionary<string, int>();

            while (input != "exam finished")
            {
                string[] data = input.Split("-");

                if (data.Length == 3)
                {
                    string name = data[0];
                    string language = data[1];
                    int points = int.Parse(data[2]);

                    if (examCounter.ContainsKey(language) == false)
                    {
                        examCounter.Add(language, 0);
                    }

                    examCounter[language] += 1;

                    if (studentsData.ContainsKey(name) == false)
                    {
                        studentsData.Add(name, 0);
                    }

                    if (studentsData[name] < points)
                    {
                        studentsData[name] = points;
                    }
                }
                else
                {
                    studentsData.Remove(data[0]);
                }

                input = Console.ReadLine();
            }

            Console.WriteLine("Results:");

            foreach (var student in studentsData.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{student.Key} | {student.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var language in examCounter)
            {
                Console.WriteLine($"{language.Key} - {language.Value}");
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAcademy
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberStudents = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> studentsGrades = new Dictionary<string, List<double>>();

            for (int i = 0; i < numberStudents; i++)
            {
                string[] input = Console.ReadLine().Split();
                string name = input[0];
                double grade = double.Parse(Console.ReadLine());

                if (studentsGrades.ContainsKey(name) == false)
                {
                    studentsGrades.Add(name, new List<double>());
                }

                studentsGrades[name].Add(grade);
            }

            foreach (var student in studentsGrades.OrderByDescending(x => x.Value.Average()))
            {
                if (student.Value.Average() >= 4.5)
                {
                    Console.WriteLine($"{student.Key} -> {student.Value.Average():f2}");
                }          
            }
        }
    }
}

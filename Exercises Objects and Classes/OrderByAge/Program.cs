using System;
using System.Collections.Generic;
using System.Linq;

namespace OrderByAge
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Student> students = new List<Student>();

            while (input.ToLower() != "end")
            {
                string[] data = input.Split();
                Student student = new Student(data[0], data[1], int.Parse(data[2]));
                students.Add(student);
                input = Console.ReadLine();
            }

            students = students.OrderBy(x => x.Age).ToList();

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} with ID: {student.ID} is {student.Age} years old.");
            }
        }
    }

    class Student
    {
        public Student(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }

        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}

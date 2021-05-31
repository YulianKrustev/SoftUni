using System;
using System.Collections.Generic;
using System.Linq;

namespace FilterByAge
{
    class Program
    {
        class Human
        {
            public int age { get; set; }
            public string name { get; set; }
        }
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            List<Human> humans = new List<Human>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                string[] currentHuman = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                Human human = new Human() { age = int.Parse(currentHuman[1]), name = currentHuman[0] };
                humans.Add(human);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string format = Console.ReadLine();

            humans.Where(Filter(condition, age)).ToList().ForEach(PrintFunk(format));

        }

        static Func<Human, bool> Filter(string condition, int age)
        {
            if (condition == "older")
            {
                return x => x.age >= age;
            }
            else
            {
                return x => x.age <= age;
            } 
        }

        static Action<Human> PrintFunk(string format)
        {
            switch (format)
            {
                case "age": return x => Console.WriteLine(x.age);
                case "name": return x => Console.WriteLine(x.name);
                default: return x => Console.WriteLine($"{x.name} - {x.age}");
            }
        }
    }
}

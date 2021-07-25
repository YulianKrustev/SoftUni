using System;
using System.Collections.Generic;

namespace ComparingObjects
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] tokens = input.Split();
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string town = tokens[2];

                Person person = new Person(name, age, town);
                people.Add(person);

                input = Console.ReadLine();
            }

            int number = int.Parse(Console.ReadLine());
            int counter = 1;

            for (int i = 0; i < people.Count; i++)
            {
                if (i != number - 1 && people[i].CompareTo(people[number - 1]) == 1)
                {
                    counter++;
                }
            }

            if (counter > 1)
            {
                Console.WriteLine($"{counter} {people.Count - counter} {people.Count}");
            }
            else
            {
                Console.WriteLine("No matches");
            }           
        }
    }
}

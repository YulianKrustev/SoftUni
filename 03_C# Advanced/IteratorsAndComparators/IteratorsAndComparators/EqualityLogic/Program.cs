using System;
using System.Collections.Generic;

namespace EqualityLogic
{
    public class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());

            SortedSet<Person> sorted = new SortedSet<Person>();

            HashSet<Person> unSorted = new HashSet<Person>();

            for (int i = 0; i < countOfPeople; i++)
            {
                string[] human = Console.ReadLine().Split();
                string name = human[0];
                int age = int.Parse(human[1]);

                Person person = new Person(name, age);

                sorted.Add(person);
                unSorted.Add(person);
            }

            Console.WriteLine(sorted.Count);
            Console.WriteLine(unSorted.Count);
        }
    }
}

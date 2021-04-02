using System;
using System.Collections.Generic;
using System.Linq;

namespace Oldest_Family_Member
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfMembers = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < numberOfMembers; i++)
            {
                family.AddMember(Console.ReadLine().Split());
            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }

    class Person
    {
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Family
    {
        public List<Person> FamilyMembers { get; set; } = new List<Person>();

        public void AddMember(string[] data)
        {
            Person person = new Person(data[0], int.Parse(data[1]));
            FamilyMembers.Add(person);
        }

        public Person GetOldestMember()
        {
            return FamilyMembers.OrderByDescending(x => x.Age).First();
        }
    }
}

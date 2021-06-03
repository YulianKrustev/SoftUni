using System;
using System.Collections.Generic;
using System.Linq;

namespace PredicateParty_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine().Split().ToList();
            string[] command = Console.ReadLine().Split();


            while (command[0] != "Party!")
            {
                string firstToken = command[0];
                string secondToken = command[1];

                if (firstToken == "Remove")
                {
                    switch (command[1])
                    {
                        case "Length":
                            people.Remove(people.Find(x => x.Length == int.Parse(command[2])));
                            break;
                        case "StartsWith":
                            StartWith(people, command[2]);
                            break;
                        case "EndsWith":
                            EndWith(people, command[2]);
                            break;
                    }
                }
                else
                {
                    switch (command[1])
                    {
                        case "Length":
                            people.Insert(1, "sad");
                            break;
                        case "StartsWith":
                            AddStartWith(people, command[2]);
                            break;
                        case "EndsWith":
                            AddEndWith(people, command[2]);
                            break;
                    }
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(", ", people));
        }

        static List<string> StartWith(List<string> people, string command)
        {
            Predicate<string> cheker = x => x.StartsWith(command);
            people.RemoveAll(cheker);
            return people;
        }

        static List<string> EndWith(List<string> people, string command)
        {
            Predicate<string> cheker = x => x.EndsWith(command);
            people.RemoveAll(cheker);
            return people;
        }

        static List<string> AddStartWith(List<string> people, string command)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].StartsWith(command))
                {
                    people.Insert(i, people[i]);
                }
            }
            return people;
        }

        static List<string> AddEndWith(List<string> people, string command)
        {
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].EndsWith(command))
                {
                    people.Insert(i, people[i]);
                }
            }
            return people;
        }

        static List<string> CheckLength(List<string> people, int length)
        {
            return people;
        }
    }
}

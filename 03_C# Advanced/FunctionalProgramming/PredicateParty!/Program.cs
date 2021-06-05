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
                string action = command[0];
                string condition = command[1];

                 if (action == "Remove")
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (condition == "StartsWith" && people[i].StartsWith(command[2]))
                        {
                            people.Remove(people[i]);
                            i--;
                        }
                        else if (condition == "EndsWith" && people[i].EndsWith(command[2]))
                        {
                            people.Remove(people[i]);
                            i--;
                        }
                        else if (condition == "Length" && people[i].Length == int.Parse(command[2]))
                        {
                            people.Remove(people[i]);
                            i--;
                        }
                    }
                    

                }
                else if (action == "Double")
                {
                    for (int i = 0; i < people.Count; i++)
                    {
                        if (condition == "StartsWith" && people[i].StartsWith(command[2]))
                        {
                            people.Insert(i, people[i]);
                            i++;
                        }
                        else if (condition == "EndsWith" && people[i].EndsWith(command[2]))
                        {
                            people.Insert(i, people[i]);
                            i++;
                        }
                        else if(condition == "Length" && people[i].Length == int.Parse(command[2]))
                        {
                            people.Insert(i, people[i]);
                            i++;
                        }
                    }
                }

                command = Console.ReadLine().Split();
            }

            if (people.Count == 0)
            {
                Console.WriteLine("Nobody is going to the party!");
            }
            else
            {
                Console.WriteLine($"{string.Join(", ", people)} are going to the party!");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Course_Planning
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coursePLaning = Console.ReadLine()
                                                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();

            List<string> command = Console.ReadLine().Split(":").ToList();

            while (command[0].ToLower() != "course start")
            {

                if (command[0].ToLower() == "add")
                {
                    if (!coursePLaning.Contains(command[1]))
                    {
                        coursePLaning.Add(command[1]);
                    }
                }
                else if (command[0].ToLower() == "insert")
                {
                    if (!coursePLaning.Contains(command[1]))
                    {
                        coursePLaning.Insert(int.Parse(command[2]), command[1]);
                    }
                }
                else if (command[0].ToLower() == "remove")
                {
                    string exercise = command[1] + "-Exercise";
                    coursePLaning.Remove(command[1]);
                    coursePLaning.Remove(exercise);
                }
                else if (command[0].ToLower() == "swap")
                {
                    if (coursePLaning.Contains(command[1]) && coursePLaning.Contains(command[2]))
                    {
                        int indexOne = coursePLaning.IndexOf(command[1]);
                        int indexTwo = coursePLaning.IndexOf(command[2]);
                        string firstLesson = coursePLaning[indexOne];
                        string secondLesson = coursePLaning[indexTwo];
                        coursePLaning[indexOne] = secondLesson;
                        coursePLaning[indexTwo] = firstLesson;
                        string exercise1 = command[1] + "-Exercise";
                        string exercise2 = command[2] + "-Exercise";

                        if (coursePLaning.Contains(exercise1))
                        {
                            coursePLaning.Remove(exercise1);
                            coursePLaning.Insert(indexTwo + 1, exercise1);
                        }
                        else if (coursePLaning.Contains(exercise2))
                        {
                            coursePLaning.Remove(exercise2);
                            coursePLaning.Insert(indexOne + 1, exercise2);
                        }
                    }
                }
                else if (command[0].ToLower() == "exercise")
                {
                    if (!coursePLaning.Contains(command[1]))
                    {
                        coursePLaning.Add(command[1]);
                        coursePLaning.Add($"{command[1]}-Exercise");
                    }
                    else if (coursePLaning.Contains(command[1]))
                    {
                        string current = command[1] + "-Exercise";
                        if (!(coursePLaning.Contains(current)))
                        {
                            int index = coursePLaning.IndexOf(command[1]);
                            coursePLaning.Insert(index + 1, current);
                        }
                    }
                }
                command = Console.ReadLine().Split(":").ToList();
            }
            for (int i = 0; i < coursePLaning.Count; i++)
            {
                Console.WriteLine($"{i + 1}.{coursePLaning[i]}");
            }
        }
    }
}

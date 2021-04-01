using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                                       .Split()
                                       .Select(int.Parse)
                                       .ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        numbers.Add(int.Parse(command[1]));
                        break;
                    case "insert":
                        if (numbers.Count <= int.Parse(command[2]) || 0 > int.Parse(command[2]))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        }                       
                        break;
                    case "remove":                       
                        if (numbers.Count <= int.Parse(command[1]) || 0 > int.Parse(command[1]))
                        {
                            Console.WriteLine("Invalid index");
                        }
                        else
                        {
                            numbers.RemoveAt(int.Parse(command[1]));
                        }
                        break;
                    case "shift":
                        if (command[1].ToLower() == "left")
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                numbers.Add(numbers[0]);
                                numbers.RemoveAt(0);
                            }                           
                        }
                        else
                        {
                            for (int i = 0; i < int.Parse(command[2]); i++)
                            {
                                numbers.Insert(0, numbers[numbers.Count - 1]);
                                numbers.RemoveAt(numbers.Count - 1);
                            }
                        }
                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersInput = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string[] command = Console.ReadLine()
                                      .Split()
                                      .ToArray();

            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        numbersInput.Add(int.Parse(command[1]));
                        break;
                    case "remove":
                        numbersInput.Remove(int.Parse(command[1]));
                        break;
                    case "removeat":
                        numbersInput.RemoveAt(int.Parse(command[1]));
                        break;
                    case "insert":
                        numbersInput.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }
                command = Console.ReadLine()
                                 .Split()
                                 .ToArray();
            }

            Console.WriteLine(string.Join(" ", numbersInput));
        }
    }
}

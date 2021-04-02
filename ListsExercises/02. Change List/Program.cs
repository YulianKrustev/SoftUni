using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfNumbers = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "delete":
                        listOfNumbers.RemoveAll(n => n == int.Parse(command[1]));
                        break;
                    case "insert":
                        listOfNumbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        break;
                }

                command = Console.ReadLine().Split();
            }

            Console.WriteLine(string.Join(" ", listOfNumbers));
        }
    }
}

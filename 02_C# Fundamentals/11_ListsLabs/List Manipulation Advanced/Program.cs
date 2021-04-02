using System;
using System.Collections.Generic;
using System.Linq;

namespace List_Manipulation_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbers = Console.ReadLine()
                                            .Split()
                                            .Select(int.Parse)
                                            .ToList();

            bool listIsChanged = false;

            string[] command = Console.ReadLine().Split();

            while (command[0].ToLower() != "end")
            {
                switch (command[0].ToLower())
                {
                    case "add":
                        inputNumbers.Add(int.Parse(command[1]));
                        listIsChanged = true;
                        break;
                    case "remove":
                        inputNumbers.Remove(int.Parse(command[1]));
                        listIsChanged = true;
                        break;
                    case "removeat":
                        inputNumbers.RemoveAt(int.Parse(command[1]));
                        listIsChanged = true;
                        break;
                    case "insert":
                        inputNumbers.Insert(int.Parse(command[2]), int.Parse(command[1]));
                        listIsChanged = true;
                        break;
                    case "contains":
                        Console.WriteLine(inputNumbers.Contains(int.Parse(command[1])) ? "Yes" : "No such number");
                        break;
                    case "printeven":
                        Console.WriteLine(string.Join(" ", inputNumbers.Where(n => n % 2 == 0)));
                        break;
                    case "printodd":
                        Console.WriteLine(string.Join(" ", inputNumbers.Where(n => n % 2 != 0)));
                        break;
                    case "getsum":
                        Console.WriteLine(inputNumbers.Sum());
                        break;
                    case "filter":
                        string result = string.Empty;

                        if (command[1] == "<")
                        {
                            result = string.Join(" ", inputNumbers.Where(n => n < int.Parse(command[2])));
                        }
                        else if (command[1] == ">")
                        {
                            result = string.Join(" ", inputNumbers.Where(n => n > int.Parse(command[2])));
                        }
                        else if (command[1] == ">=")
                        {
                            result = string.Join(" ", inputNumbers.Where(n => n >= int.Parse(command[2])));
                        }
                        else if (command[1] == "<=")
                        {
                            result = string.Join(" ", inputNumbers.Where(n => n <= int.Parse(command[2])));
                        }

                        Console.WriteLine(result);
                        break;
                }

                command = Console.ReadLine().Split();
            }

            if (listIsChanged)
            {
                Console.WriteLine(string.Join(" ", inputNumbers));
            }
        }
    }
}

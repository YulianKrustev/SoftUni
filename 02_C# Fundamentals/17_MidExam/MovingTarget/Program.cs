using System;
using System.Collections.Generic;
using System.Linq;

namespace MovingTarget
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToList();

            string command = Console.ReadLine();

            while (command.ToUpper() != "END")
            {
                string[] commandArg = command.Split();
                string action = commandArg[0];
                int index = int.Parse(commandArg[1]);
                int number = int.Parse(commandArg[2]);

                switch (action.ToUpper())
                {
                    case "SHOOT":
                        if (index >= 0 && index < input.Count)
                        {
                            if (number < input[index])
                            {
                                input[index] -= number;
                            }
                            else
                            {
                                input.RemoveAt(index);
                            }
                        }
                        break;

                    case "ADD":
                        if (index >= 0 && index < input.Count)
                        {
                            input.Insert(index, number);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }
                        break;

                    case "STRIKE":
                        if (index - number >= 0 && index + number < input.Count)
                        {
                            input.RemoveRange(index - number, (number * 2) + 1);
                        }
                        else 
                        {
                            Console.WriteLine("Strike missed!");
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join("|", input));
        }
    }
}

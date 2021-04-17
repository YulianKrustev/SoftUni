using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stackOfNumbers = new Stack<int>(input);
            string command = Console.ReadLine();

            while (command != "end")
            {
                string[] tokens = command.Split();

                switch (tokens[0])
                {
                    case "add": 
                        stackOfNumbers.Push(int.Parse(tokens[1])); 
                        stackOfNumbers.Push(int.Parse(tokens[2]));
                        break;
                    case "remove":

                        int elemntsToRemove = int.Parse(tokens[1]);

                        if (elemntsToRemove <= stackOfNumbers.Count)
                        {
                            for (int i = 0; i < elemntsToRemove; i++)
                            {
                                stackOfNumbers.Pop();
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            Console.WriteLine($"Sum: {stackOfNumbers.Sum()}");
        }
    }
}

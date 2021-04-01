using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Anonymous_Threat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                        .Split()
                                        .ToList();

            string[] command = Console.ReadLine().Split();

            while (command[0] != "3:1")
            {
                switch (command[0].ToLower())
                {
                    case "merge":
                        for (int i = int.Parse(command[1]); i <= int.Parse(command[2]); i++)
                        {
                            if (i >= 0 && i < input.Count - 1)
                            {
                                input[i] += input[i + 1];
                                input.RemoveAt(i + 1);
                                i--;
                            }
                        }
                        break;
                    case "divide":
                        string current = input[int.Parse(command[1])];

                        if (current.Length < int.Parse(command[2]))
                        {
                            continue;
                        }
                        ;
                        input.RemoveAt(int.Parse(command[1]));
                        string[] final = new string[int.Parse(command[2])];
                        
                        int index = 0;
                        for (int j = 0; j < int.Parse(command[2]); j++)
                        {
                            if (j == int.Parse(command[2]) + 1 && current.Length % int.Parse(command[2]) != 0)
                            {
                                final[j] = current.Substring(index, current.Length % int.Parse(command[2]) + current.Length / int.Parse(command[2]));
                                index += current.Length / int.Parse(command[2]);
                            }
                            else
                            {
                                final[j] = current.Substring(index, current.Length / int.Parse(command[2]));
                                index += current.Length / int.Parse(command[2]);
                            }                        
                        }

                        Array.Reverse(final);


                        for (int i = 0; i < final.Length; i++)
                        {
                            
                            input.Insert(int.Parse(command[1]), final[i]);
                        }

                        break;
                }
                command = Console.ReadLine().Split();
            }
            Console.WriteLine(string.Join(" ", input));
        }
    }
}

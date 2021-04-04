using System;
using System.Linq;

namespace FinalExamLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string rawKey = Console.ReadLine();

            while (rawKey != "Generate")
            {
                string[] command = rawKey.Split(">>>");

                if (command[0] == "Contains")
                {
                    if (input.Contains(command[1]))
                    {
                        Console.WriteLine($"{input} contains {command[1]}");
                    }
                    else
                    {
                        Console.WriteLine("Substring not found!");
                    }
                }
                else if (command[0] == "Flip")
                {
                    int startIndex = int.Parse(command[2]);
                    int endIndex = int.Parse(command[3]);
                    string flipedString = input.Substring(startIndex, endIndex - startIndex);

                    if (command[1] == "Upper")
                    {
                        flipedString = flipedString.ToUpper();
                    }
                    else if (command[1] == "Lower")
                    {
                        flipedString = flipedString.ToLower();
                    }

                    input = input.Replace(input.Substring(startIndex, endIndex - startIndex), flipedString);
                    Console.WriteLine(input);
                }
                else if (command[0] == "Slice")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]) - 1;
                    input = input.Remove(startIndex, endIndex - startIndex +1);
                    Console.WriteLine(input);
                }

                rawKey = Console.ReadLine();
            }

            Console.WriteLine($"Your activation key is: {input}");
        }
    }
}

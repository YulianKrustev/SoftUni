using System;

namespace PasswordReset
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Done")
            {
                string current = string.Empty;
                string[] tokens = command.Split();
                bool isNotToRep = false;

                if (command == "TakeOdd")
                {
                    for (int i = 1; i < input.Length; i += 2)
                    {
                        current += input[i];
                        
                    }
                    input = current;
                }
                else if (tokens[0] == "Cut")
                {
                    int startIndex = int.Parse(tokens[1]);
                    int substringLen = int.Parse(tokens[2]);

                    input = input.Remove(startIndex, substringLen);
                }
                else if (tokens[0] == "Substitute")
                {
                    if (input.Contains(tokens[1]))
                    {
                        input = input.Replace(tokens[1], tokens[2]);
                    }
                    else
                    {
                        Console.WriteLine("Nothing to replace!");
                        isNotToRep = true;
                    }
                }

                if (!isNotToRep)
                {
                    Console.WriteLine(input);
                }
                
                command = Console.ReadLine();
            }

            Console.WriteLine($"Your password is: {input}");
        }
    }
}

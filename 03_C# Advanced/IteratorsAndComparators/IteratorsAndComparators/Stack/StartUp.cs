using System;
using System.Linq;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            CustomStack<string> elements = new CustomStack<string>(); 

            while (input != "END")
            {
                string[] tokens = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (tokens[0] == "Push")
                {
                    elements.Push(tokens.Skip(1).ToArray());
                }
                else
                {
                    try
                    {
                        elements.Pop();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    
                }

                input = Console.ReadLine();
            }

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }

            foreach (var element in elements)
            {
                Console.WriteLine(element);
            }
        }
    }
}

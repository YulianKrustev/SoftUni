using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var input = new StreamReader("input.txt"))
            {
                int counter = 1;

                while (!input.EndOfStream)
                {
                    counter++;
                    string currentLine = input.ReadLine();

                    if (counter % 2 == 1)
                    {
                        using (var output = new StreamWriter("output.txt", true))
                        {
                            output.WriteLine(currentLine);
                        }
                    }
                }
            }

            using (var output = new StreamReader("output.txt"))
            {
                while (!output.EndOfStream)
                {

                    Console.WriteLine(output.ReadLine());
                }
            }
        }
    }
}

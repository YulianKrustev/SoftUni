using System;
using System.IO;

namespace OddLines
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            using (var input = new StreamReader("input.txt"))
            {
                while (input.EndOfStream == false)
                {
                    counter++;
                    string currentLine = input.ReadLine();

                    if (counter % 2 == 0)
                    {
                        Console.WriteLine(currentLine);
                    }
                }
            }
        }
    }
}

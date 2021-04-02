using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine()
                                        .Split()
                                        .ToList();

            Console.WriteLine(input[1][2]);
        }
    }
}

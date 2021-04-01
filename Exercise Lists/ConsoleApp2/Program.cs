using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coursePLaning = Console.ReadLine()
                                                .Split(":", StringSplitOptions.RemoveEmptyEntries)
                                                .ToList();
            Console.WriteLine(coursePLaning[0]);
        }
    }
}

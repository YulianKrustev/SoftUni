using System;
using System.Linq;

namespace ActionPoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> Print = Console.WriteLine;
            Console.ReadLine()
                .Split()
                .ToList().
                ForEach(x => Print(x));
        }
    }
}

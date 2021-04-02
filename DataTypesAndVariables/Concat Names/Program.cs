using System;

namespace Concat_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOne = Console.ReadLine();
            string nameTwo = Console.ReadLine();
            string delimeter = Console.ReadLine();

            Console.WriteLine($"{nameOne}{delimeter}{nameTwo}");
        }
    }
}

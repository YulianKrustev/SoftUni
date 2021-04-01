using System;

namespace Chars_to_String
{
    class Program
    {
        static void Main(string[] args)
        {
            char inputOne = Console.ReadLine()[0];
            char inputTwo = Console.ReadLine()[0];
            char inputThree = Console.ReadLine()[0];

            Console.WriteLine($"{inputOne}{inputTwo}{inputThree}");
        }
    }
}

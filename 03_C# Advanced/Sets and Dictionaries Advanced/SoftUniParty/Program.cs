using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> database = new HashSet<string>();

            string input = Console.ReadLine();

            while (input != "PARTY")
            {
                database.Add(input);

                input = Console.ReadLine();
            }

            while (input != "END")
            {
                database.Remove(input);

                input = Console.ReadLine();
            }

            Console.WriteLine(database.Count);

            foreach (var guest in database)
            {
                if (char.IsDigit(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }

            foreach (var guest in database)
            {
                if (char.IsLetter(guest[0]))
                {
                    Console.WriteLine(guest);
                }
            }
        }
    }
}

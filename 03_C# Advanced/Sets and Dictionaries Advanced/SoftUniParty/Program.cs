using System;
using System.Collections.Generic;

namespace SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> database = new HashSet<string>();
            HashSet<string> vipp = new HashSet<string>();
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

            foreach (var vip in database)
            {   
                if (int.TryParse(vip[0].ToString(), out _))
                {
                    vipp.Add(vip);
                    database.Remove(vip);
                }
            }

            Console.WriteLine(database.Count +vipp.Count);

            foreach (var guest in vipp)
            {
                Console.WriteLine(guest);
            }

            foreach (var guest in database)
            {
                Console.WriteLine(guest);
            }
        }
    }
}

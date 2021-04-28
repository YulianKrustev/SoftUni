﻿using System;
using System.Collections.Generic;

namespace RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int countNames = int.Parse(Console.ReadLine());

            HashSet<string> names = new HashSet<string>(); 

            for (int i = 0; i < countNames; i++)
            {
                names.Add(Console.ReadLine());
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

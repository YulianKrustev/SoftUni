﻿using System;
using System.Linq;

namespace Word_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split().Where(w => w.Length % 2 == 0).ToList().ForEach(w => { Console.WriteLine(w); });
        }
    }
}

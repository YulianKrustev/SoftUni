﻿using System;

namespace Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            char input = Console.ReadLine()[0];
            int charAsInt = (int)input;

            if (charAsInt <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}

﻿using System;

namespace Intro_and_Basic_Syntax_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            string type = string.Empty;
            if (age >=0 && age <= 2)
            {
                type = "baby";
            }
            else if (age >= 3 && age <= 13)
            {
                type = "child";
            }
            else if (age >= 14 && age <= 19)
            {
                type = "teenager";
            }
            else if (age >= 20 && age <= 65)
            {
                type = "adult";
            }
            else
            {
                type = "elder";
            }
            Console.WriteLine(type);
        }
    }
}

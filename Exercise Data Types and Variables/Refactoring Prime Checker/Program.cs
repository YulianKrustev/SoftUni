﻿using System;

namespace Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i <= n; i++)
            {
                string prime = "true";
                for (int j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        prime = "false";
                        break;
                    }
                }
                Console.WriteLine("{0} -> {1}", i, prime);
            }

        }
    }
}

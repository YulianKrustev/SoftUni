﻿using System;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            double result = DateModifier.GetDiffBetweenTwoDates(firstDate, secondDate);

            Console.WriteLine(result);
        }
    }
}

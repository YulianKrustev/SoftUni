﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        private const double cakeGrams = 250;
        private const decimal cakePrice = 5;
        private const double cakeCalories = 1000;

        public Cake(string name) : base(name, cakePrice, cakeGrams, cakeCalories)
        {
        }
    }
}

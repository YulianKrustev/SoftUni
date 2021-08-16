﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get;private set; }
        public decimal Price { get; private set; }
    }
}

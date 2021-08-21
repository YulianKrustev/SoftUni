using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public abstract class Starter : Food
    {
        protected Starter(string name, decimal price, double grams) : base(name, price, grams)
        {
        }
    }
}

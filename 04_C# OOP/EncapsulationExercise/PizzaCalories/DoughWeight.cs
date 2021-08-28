using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class DoughWeight
    {
        public static bool CheckWeight(double weight)
        {
            return weight >= 1 && weight <= 200;
        }
    }
}

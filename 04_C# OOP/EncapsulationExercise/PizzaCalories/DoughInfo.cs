using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class FlourInfo
    {
        private static Dictionary<string, double> flours = new Dictionary<string, double>
        {
            { "white", 1.5 },
            { "wholegrain", 1.0 }
        };

        public static Dictionary<string, double> Flours => flours;

    }
}

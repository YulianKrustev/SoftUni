using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public static class BakingTechniquesInfo
    {
        private static Dictionary<string, double> bakingTechniques = new Dictionary<string, double>
        {
            { "crispy", 0.9 },
            { "chewy", 1.1 },
            { "homemade", 1.0 }
        };
        public static Dictionary<string, double> BakingTechniques => bakingTechniques;
    }
}

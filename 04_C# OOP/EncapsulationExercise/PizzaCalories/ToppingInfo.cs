using System.Collections.Generic;

namespace PizzaCalories
{
    public static class ToppingInfo
    {
        private static Dictionary<string, double> toppingTypes = new Dictionary<string, double>
        {
            { "meat", 1.2 },
            { "veggies", 0.8 },
            { "cheese", 1.1 },
            { "sauce", 0.9 }
        };
        public static Dictionary<string, double> ToppingTypes => toppingTypes;
    }
}


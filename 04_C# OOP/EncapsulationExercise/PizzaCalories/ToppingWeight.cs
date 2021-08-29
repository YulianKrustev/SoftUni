namespace PizzaCalories
{
    public static class ToppingWeight
    {
        public static bool CheckWeight(double weight)
        {
            return weight >= 1 && weight <= 50;
        }
    }
}

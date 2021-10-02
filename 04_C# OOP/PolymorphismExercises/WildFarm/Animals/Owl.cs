using System.Collections.Generic;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Owl : Bird
    {
        private const double increaseWeight = 0.25;
        private readonly IList<string> favoriteFood = new List<string> { "Meat" };

        public Owl(string name, double weight, double wingSize) 
            : base(name, weight, wingSize)
        {
        }

        public override string ProducingSound()
        {
            return "Hoot Hoot";
        }

        public override void FeedIt(Foods food)
        {
            if (favoriteFood.Contains(food.GetType().Name))
            {
                FoodEaten = food.Quantity;
                Weight += food.Quantity * increaseWeight;
            }
            else
            {
                System.Console.WriteLine($"{GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
using System.Collections.Generic;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Mouse : Mammal
    {
        private const double increaseWeight = 0.1;
        private readonly IList<string> favoriteFood = new List<string> { "Fruit", "Vegetable" };
        public Mouse(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string ProducingSound()
        {
            return "Squeak";
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
using System.Collections.Generic;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Tiger : Feline
    {
        private const double increaseWeight = 1;
        private readonly IList<string> favoriteFood = new List<string> { "Meat" };

        public Tiger(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProducingSound()
        {
            return "ROAR!!!";
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
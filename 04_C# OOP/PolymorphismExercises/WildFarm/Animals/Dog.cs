using System.Collections.Generic;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Dog : Mammal
    {
        private const double increaseWeight = 0.4;
        private readonly IList<string> favoriteFood = new List<string> { "Meat" };

        public Dog(string name, double weight, string livingRegion) 
            : base(name, weight, livingRegion)
        {
        }

        public override string ProducingSound()
        {
            return "Woof!";
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
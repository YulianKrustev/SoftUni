using System.Collections.Generic;
using WildFarm.Food;

namespace WildFarm.Animals
{
    public class Cat : Feline
    {
        private const double increaseWeight = 0.3;
        private readonly IList<string> favoriteFood = new List<string> { "Vegetable","Meat" };

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, livingRegion, breed)
        {
        }

        public override string ProducingSound()
        {
            return "Meow";
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
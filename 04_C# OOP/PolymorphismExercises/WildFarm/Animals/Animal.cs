using WildFarm.Food;

namespace WildFarm.Animals
{
    public abstract class Animal
    {
        public Animal(string name, double weight)
        {
            Name = name;
            Weight = weight;
        }

        public string Name { get; }
        public double Weight { get; protected set; }

        public int FoodEaten { get; protected set; }

        public virtual string ProducingSound()
        {
            return null;
        }

        public virtual void FeedIt(Foods food)
        {
        }
    }
}
using System;
namespace Animals
{
    public abstract class Animal
    {
        private string name;
        private string favoriteFood;

        protected Animal(string name, string favoriteFood)
        {
            this.name = name;
            this.favoriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {name} and my fovourite food is {favoriteFood}";
        }
    }
}

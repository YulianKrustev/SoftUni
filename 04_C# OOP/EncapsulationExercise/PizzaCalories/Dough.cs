using System;

namespace PizzaCalories
{
    public class Dough
    {
        private const int calPerGram = 2;
        private string flourType;
        private string baakingTechnique;
        private double weigth;

        public Dough(string flourType, string bakingTechniques, double wight)
        {
            FlourType = flourType;
            BakingTechniques = bakingTechniques;
            Weight = wight;
        }

        public string FlourType 
        {
            get => flourType;
            private set
            {
                if (FlourInfo.Flours.ContainsKey(value.ToLower()) == false)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                flourType = value;
            }
        }

        public string BakingTechniques
        {
            get => baakingTechnique;
            private set
            {
                if (BakingTechniquesInfo.BakingTechniques.ContainsKey(value.ToLower()) == false)
                {
                    throw new ArgumentException("Invalid type of dough.");
                }

                baakingTechnique = value;
            }
        }

        public double Weight
        {
            get => weigth;
            private set
            {
                if (DoughWeight.CheckWeight(value) == false)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                weigth = value;
            }
        }

        public double Calories => weigth * calPerGram * FlourInfo.Flours[flourType.ToLower()] * BakingTechniquesInfo.BakingTechniques[baakingTechnique.ToLower()];
    }
}

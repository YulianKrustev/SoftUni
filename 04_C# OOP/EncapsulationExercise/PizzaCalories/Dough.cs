using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Dough
    {
        private const int calPerGram = 2;
        private string flourType;
        private string baakingTechnique;
        private double weigth;
        private double calories;

        public Dough(string flourType, string bakingTechniques, double wight)
        {
            FlourType = flourType;
            BakingTechniques = bakingTechniques;
            Wight = wight;
            calories = DoughthCalories();
        }

        public string FlourType 
        {
            get => flourType;
            set
            {
                if (FlourInfo.Flours.ContainsKey(value) == false)
                {
                    throw new ArgumentException("Invalid type of dough");
                }

                flourType = value;
            }
        }

        public string BakingTechniques
        {
            get => baakingTechnique;
            set
            {
                if (BakingTechniquesInfo.BakingTechniques.ContainsKey(value) == false)
                {
                    throw new ArgumentException("Invalid type of dough");
                }

                baakingTechnique = value;
            }
        }

        public double Wight
        {
            get => weigth;
            set
            {
                if (DoughWeight.CheckWeight(value) == false)
                {
                    throw new ArgumentException("Dough weight should be in the range [1..200].");
                }

                weigth = value;
            }
        }

        public double Calories => calories;

        private double DoughthCalories()
        {
            return weigth* calPerGram *FlourInfo.Flours[flourType] * BakingTechniquesInfo.BakingTechniques[baakingTechnique];
        }
    }
}

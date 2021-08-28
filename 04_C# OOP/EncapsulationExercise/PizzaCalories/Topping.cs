using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int caloriesPerGram = 2;
        private string toppingType;
        private double weight;

        public Topping(string toppingType, double weight)
        {
            ToppingType = toppingType;
            Weight = weight;
        }

        public string ToppingType 
        { 
            get => toppingType;
            set 
            {
                if (ToppingInfo.ToppingTypes.ContainsKey(value) == false)
                {
                    throw new ArgumentException($"Cannot place {value} on top of your pizza.");
                }

                toppingType = value;
            }
        }

        public double Weight
        {
            get => weight;
            set
            {
                if (ToppingWeight.CheckWeight(value) == false)
                {
                    throw new ArgumentException($"{toppingType} weight should be in the range [1..50].");
                }

                weight = value;
            }
        }

        public double ToppingCalories => caloriesPerGram * weight * ToppingInfo.ToppingTypes[toppingType];
    }
}

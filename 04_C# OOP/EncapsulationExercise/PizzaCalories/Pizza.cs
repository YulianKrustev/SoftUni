using System;
using System.Collections.Generic;
using System.Linq;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough)
        {
            Name = name;
            Dough = dough;
            toppings = new List<Topping>();
        }
        public string Name 
        {
            get => name; 
            private set
            {
                if (value == string.Empty || value.Length > 16)
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            } 
        }
        public Dough Dough { get; }

        public int ToppingsCount => toppings.Count;

        public double TotalCalories => Dough.Calories + toppings.Sum(x => x.ToppingCalories);

        public void AddToping(Topping topping)
        {
            if (toppings.Count == 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

            toppings.Add(topping);
        }
    }
}

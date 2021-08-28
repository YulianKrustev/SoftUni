using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaCalories
{
    public class Pizza
    {
        private string name;
        private List<Topping> toppings;

        public Pizza(string name, Dough dough, Topping topping)
        {
            Name = name;
            toppings = new List<Topping>();
        }
        public string Name 
        {
            get => name; 
            private set
            {
                if (value.Length < 0 || value.Length > 16 || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
                }

                name = value;
            } 
        }
        public Dough Dough { get; set; }
        public IReadOnlyList<Topping> Toppings
        {
            get => toppings.AsReadOnly();

        }
        public double TotalCalories => GetTotalCalories();

        private double GetTotalCalories()
        {
            double totalCalories = Dough.Calories;

            foreach (Topping topping in toppings)
            {
                totalCalories += topping.ToppingCalories;
            }

            return totalCalories;
        }

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

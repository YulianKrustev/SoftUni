using System;

namespace AnimalFarm.Models
{
    public class Chicken
    {
        private const int minAge = 0;
        private const int maxAge = 15;

        private string name;
        private int age;

        internal Chicken(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public string Name
        {
            get { return this.name; }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }

                this.name = value;
            }
        }

        public int Age
        {
            get { return this.age; }

            private set
            {
                if (value < minAge || value > maxAge)
                {
                    throw new ArgumentException("Age should be between 0 and 15.");
                }

                this.age = value;
            }
        }

        public double ProductPerDay => this.CalculateProductPerDay();

        private double CalculateProductPerDay()
        {
            if (this.age <= 3)
            {
                return 1.5;
            }
            else if (this.age <= 7)
            {
                return 2;
            }
            else if (this.age <= 11)
            {
                return 1;
            }
            else
            {
                return 0.75;
            }
        }
    }
}

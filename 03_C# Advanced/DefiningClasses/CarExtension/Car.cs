using System;
using System.Collections.Generic;
using System.Text;

namespace CarExtension
{
    public class Car
    {
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double consumation = FuelConsumption * distance / 100;
            if (FuelQuantity - consumation > 0)
            {
                FuelQuantity -= consumation;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string WhoAmI()
        {
            return $"Make: { this.Make}\nModel: { this.Model}\nYear: { this.Year}\nFuel: { this.FuelQuantity:F2}L";
        }
    }
}

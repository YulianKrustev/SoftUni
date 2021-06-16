using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        public string model;
        public double fuelAmount;
        public double consumptionPerKm;
        public double distance;

        public Car(string model, double fuelAmount, double consumptionPerKm)
        {
            this.model = model;
            this.fuelAmount = fuelAmount;
            this.consumptionPerKm = consumptionPerKm;
        }

        public void Drive(double distance)
        {
            double neededFuel = distance * this.consumptionPerKm;

            if (neededFuel <= this.fuelAmount)
            {
                this.distance += distance;
                this.fuelAmount -= neededFuel;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
        }
    }
}

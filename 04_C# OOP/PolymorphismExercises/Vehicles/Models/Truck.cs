using System;

namespace Vehicles.Models
{
    public class Truck : Vehicle
    {
        private const double airConditionerConsumption = 1.6;
        private const double percentageFuelAfterRefueled = 0.95;

        public Truck(double fuelQuantity, double fuelConsumption)
            : base(fuelQuantity, fuelConsumption)
        {
        }

        public override void Drive(double distance)
        {
            double neededFuel = (FuelConsumption + airConditionerConsumption) * distance;

            if (neededFuel <= FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                this.TravelledDistance += distance;

                Console.WriteLine($"Truck travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Truck needs refueling");
            }
        }

        public override void Refueled(double liters)
        {
            this.FuelQuantity += liters * percentageFuelAfterRefueled;
        }
    }
}
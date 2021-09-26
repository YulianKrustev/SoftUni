using System;

namespace VehiclesExtension.Models
{
    public class Car : Vehicle
    {
        private const double airConditionerConsumption = 0.9;

        public Car(double fuelQuantity, double fuelConsumption, double tankCapacity) 
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public override void Drive(double distance)
        {
            double neededFuel = (FuelConsumption + airConditionerConsumption) * distance;

            if (neededFuel <= FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                this.TravelledDistance += distance;

                Console.WriteLine($"Car travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Car needs refueling");
            }
        }
    }
}
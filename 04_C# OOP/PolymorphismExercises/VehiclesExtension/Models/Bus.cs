using System;

namespace VehiclesExtension.Models
{
    public class Bus : Vehicle
    {
        private const double airConditionerConsumption = 1.4;

        public Bus(double fuelQuantity, double fuelConsumption, double tankCapacity)
            : base(fuelQuantity, fuelConsumption, tankCapacity)
        {
        }

        public bool BusIsEmpty { get; set; }

        public override void Drive(double distance)
        {
            double neededFuel;

            if (BusIsEmpty)
            {
                neededFuel = FuelConsumption * distance;
            }
            else
            {
                neededFuel = (FuelConsumption + airConditionerConsumption) * distance;
            }
            
            if (neededFuel <= FuelQuantity)
            {
                this.FuelQuantity -= neededFuel;
                this.TravelledDistance += distance;

                Console.WriteLine($"Bus travelled {distance} km");
            }
            else
            {
                Console.WriteLine("Bus needs refueling");
            }
        }
    }
}

namespace Vehicles.Models
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelConsumption;
        private double travelledDistance;

        protected Vehicle(double fuelQuantity, double fuelConsumption)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }

        public double FuelQuantity
        {
            get { return fuelQuantity; }
            set { fuelQuantity = value; }
        }

        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public double TravelledDistance
        {
            get { return travelledDistance; }
            protected set { travelledDistance = value; }
        }

        public virtual void Drive(double distance)
        {
        }

        public virtual void Refueled(double liters)
        {
        }
    }
}
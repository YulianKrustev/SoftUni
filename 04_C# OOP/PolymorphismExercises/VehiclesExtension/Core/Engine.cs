using System;
using VehiclesExtension.Models;

namespace VehiclesExtension.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] readingCarInfo = Console
                .ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string[] readingTruckInfo = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string[] readingBusInfo = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(readingCarInfo[1]);
            double carFuelConsumption = double.Parse(readingCarInfo[2]);
            double carTankCapacity = double.Parse(readingCarInfo[3]);
            Car car = new Car(carFuelQuantity, carFuelConsumption, carTankCapacity);

            double truckFuelQuantity = double.Parse(readingTruckInfo[1]);
            double truckFuelConsumption = double.Parse(readingTruckInfo[2]);
            double truckTankCapacity = double.Parse(readingTruckInfo[3]);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption, truckTankCapacity);

            double busFuelQuantity = double.Parse(readingBusInfo[1]);
            double busFuelConsumption = double.Parse(readingBusInfo[2]);
            double busTankCapacity = double.Parse(readingBusInfo[3]);
            Bus bus = new Bus(busFuelQuantity, busFuelConsumption, busTankCapacity);

            int countOfCommands = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCommands; i++)
            {
                string[] inputCommandAndData = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string command = inputCommandAndData[0];
                string typeOfVehicle = inputCommandAndData[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(inputCommandAndData[2]);

                    switch (typeOfVehicle)
                    {
                        case "Car":
                            car.Drive(distance);
                            break;
                        case "Truck": 
                            truck.Drive(distance); 
                            break;
                        case "Bus":
                            bus.BusIsEmpty = false;
                            bus.Drive(distance);
                            break;
                    }
                }
                else if (command == "DriveEmpty")
                {
                    double distance = double.Parse(inputCommandAndData[2]);
                    bus.BusIsEmpty = true;
                    bus.Drive(distance);
                }
                else if (command == "Refuel")
                {
                    double litersToRefuel = double.Parse(inputCommandAndData[2]);

                    switch (typeOfVehicle)
                    {
                        case "Car":
                            car.Refueled(litersToRefuel);
                            break;
                        case "Truck":
                            truck.Refueled(litersToRefuel);
                            break;
                        case "Bus":
                            bus.Refueled(litersToRefuel);
                            break;
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
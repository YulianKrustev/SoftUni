using System;
using Vehicles.Models;

namespace Vehicles.Core
{
    public class Engine
    {
        public void Run()
        {
            string[] readingCarInfo = Console
                .ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            string[] inputTruckInfo = Console
                .ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(readingCarInfo[1]);
            double carFuelConsumption = double.Parse(readingCarInfo[2]);
            Car car = new Car(carFuelQuantity, carFuelConsumption);

            double truckFuelQuantity = double.Parse(inputTruckInfo[1]);
            double truckFuelConsumption = double.Parse(inputTruckInfo[2]);
            Truck truck = new Truck(truckFuelQuantity, truckFuelConsumption);

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
                    }
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
                    }
                }
            }

            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
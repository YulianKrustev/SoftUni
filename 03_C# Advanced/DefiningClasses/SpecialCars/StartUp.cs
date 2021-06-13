using System;
using System.Collections.Generic;
using System.Linq;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Tire[]> tires = new List<Tire[]>();
            string inputTire = Console.ReadLine();

            while (inputTire != "No more tires")
            {
                string[] command = inputTire.Split();
                List<Tire> tire = new List<Tire>();

                for (int i = 0; i < command.Length; i+=2)
                {
                    int currentYear = int.Parse(command[i]);
                    double currentPressure = double.Parse(command[i+1]);
                    Tire currentTire = new Tire(currentYear, currentPressure);

                    tire.Add(currentTire);
                }

                tires.Add(tire.ToArray());

                inputTire = Console.ReadLine();
            }

            List<Engine> engines = new List<Engine>();
            string inputEngine = Console.ReadLine();

            while (inputEngine != "Engines done")
            {
                string[] command = inputEngine.Split();
                int horsePower = int.Parse(command[0]);
                double cubicCapacity = double.Parse(command[1]);
                Engine currentEngine = new Engine(horsePower, cubicCapacity);
                engines.Add(currentEngine);

                inputEngine = Console.ReadLine();
            }

            List<Car> cars = new List<Car>();
            string inputCar = Console.ReadLine();

            while (inputCar != "Show special")
            {
                string[] command = inputCar.Split();
                string make = command[0];
                string model = command[1];
                int year = int.Parse(command[2]);
                double fuelQuantity = double.Parse(command[3]);
                double fuelConsumtion = double.Parse(command[4]);
                int enginIndex = int.Parse(command[5]); 
                int tireIndex = int.Parse(command[6]);

                Car car = new Car(make, model, year, fuelQuantity, fuelConsumtion, engines[enginIndex], tires[tireIndex]);
                cars.Add(car);
                inputCar = Console.ReadLine();
            }

            foreach (Car car in cars.Where(x => x.Year >= 2017).Where(x => x.Engine.HorsePower > 330).Where(x => x.Tires.Sum(x => x.Pressure) > 9 && x.Tires.Sum(x => x.Pressure) < 10))
            {
                car.Drive(20);

                Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}\nHorsePowers: {car.Engine.HorsePower}\nFuelQuantity: {car.FuelQuantity}");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace Vehicle_Catalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Car> cars = new List<Car>();
            List<Truck> trucks = new List<Truck>();

            while (input != "end")
            {
                string[] data = input.Split("/");

                if (data[0] == "Car")
                {

                    Car car = new Car()
                    {
                        Brand = data[1],
                        Model = data[2],
                        HoursePower = int.Parse(data[3])
                    };
                    cars.Add(car);
                }
                else
                {
                    Truck truck = new Truck() 
                    {
                        Brand = data[1],
                        Model = data[2],
                        Weight = int.Parse(data[3])
                    };
                    trucks.Add(truck);
                }

                input = Console.ReadLine();
            }

            if (cars.Count > 0)
            {
                Console.WriteLine("Cars:");

                foreach (Car car in cars.OrderBy(x => x.Brand).ToList())
                {
                    Console.WriteLine($"{car.Brand}: {car.Model} - {car.HoursePower}hp");
                }
            }

            if (trucks.Count > 0)
            {
                Console.WriteLine("Trucks:");

                foreach (Truck truck in trucks.OrderBy(x => x.Brand).ToList())
                {
                    Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
                }
            }
            

        }

        public class Car
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int HoursePower { get; set; }
        }

        public class Truck
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public double Weight { get; set; }
        }

        public class VehicleCatalogue
        {
            public VehicleCatalogue()
            {
                Car car = new Car();
                Truck truck = new Truck();
            }

            public List<Car> cars { get; set; }
            public List<Truck> trucks { get; set; }
        }
    }
}

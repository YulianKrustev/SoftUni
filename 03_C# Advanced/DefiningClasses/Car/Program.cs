using System;

namespace CarManufacturer
{
    class Program
    {
        class Car
        {
            public string Make { get; set; }
            public string Model { get; set; }
            public string Year { get; set; }
        }
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "Polo";
            car.Year = "2017";

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");
        }
    }
}

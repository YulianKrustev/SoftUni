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
            List<VechelCatalogue> catalogue = new List<VechelCatalogue>();

            while (input.ToLower() != "end")
            {
                string[] data = input.Split();

                if (data[0] == "car")
                {
                    data[0] = "Car";
                }
                else
                {
                    data[0] = "Truck";
                }

                VechelCatalogue vechele = new VechelCatalogue(data[0], data[1], data[2], int.Parse(data[3]));
                catalogue.Add(vechele);
                input = Console.ReadLine();
            }

            string vecheleToFind = Console.ReadLine();

            while (vecheleToFind != "Close the Catalogue")
            {
                int index = catalogue.FindIndex(x => x.Model == vecheleToFind);

                Console.WriteLine($"Type: {catalogue[index].Type}");
                Console.WriteLine($"Model: {catalogue[index].Model}");
                Console.WriteLine($"Color: {catalogue[index].Color}");
                Console.WriteLine($"Horsepower: {catalogue[index].HorsePower}");

                vecheleToFind = Console.ReadLine();
            }
            int vechelesHP = 0;
            int trucksHP = 0;
            int vecheleCount = 0;
            int truckCount = 0;

            for (int i = 0; i < catalogue.Count; i++)
            {
                if (catalogue[i].Type == "Car")
                {
                    vechelesHP += catalogue[i].HorsePower;
                    vecheleCount++;
                }
                else
                {
                    trucksHP += catalogue[i].HorsePower;
                    truckCount++;
                }
            }

            double avarageHPVechele = 0.00;

            if (vecheleCount > 0)
            {
                avarageHPVechele = 1.0 * vechelesHP / vecheleCount;
            }

            double avarageHPTruck = 0.00;

            if (truckCount > 0)
            {
                avarageHPTruck = 1.0 * trucksHP / truckCount;
            }

            Console.WriteLine($"Cars have average horsepower of: {avarageHPVechele:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {avarageHPTruck:f2}.");

        }
    }
    class VechelCatalogue
    {
        public VechelCatalogue(string type, string model, string color, int horsePower)
        {
            Type = type;
            Model = model;
            Color = color;
            HorsePower = horsePower;
        }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int HorsePower { get; set; }
    }
}

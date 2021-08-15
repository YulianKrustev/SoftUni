﻿using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Vehicle
    {
        private const double defaultFuelConsumption = 1.25;
        
        public Vehicle(int horsePower, double fuel)
        {
            HorsePower = horsePower;
            Fuel = fuel;
        }

        public int HorsePower { get; set; }
        public double Fuel { get; set; }
        public virtual double fuelConsumption => defaultFuelConsumption;

        public virtual void Drive(double km)
        {
            double neededFuel = km * fuelConsumption / 100;

            if (neededFuel <= Fuel)
            {
                Fuel -= neededFuel;
            }
        }
    }
}

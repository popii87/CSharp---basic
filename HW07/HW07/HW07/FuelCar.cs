using System;
using System.Collections.Generic;
using System.Text;
using HW07.Enums;

namespace HW07
{
    public class FuelCar : Car
    {
        public double FuelCapacity { get; set; }
        public double CurrentFuel { get; set; }
        public FuelCar(int id, string brand, string model, int doors, int topspeed, double fuelCapacity, double currentFuel) : base(id, brand, model, doors, topspeed, Consumption.Medium, EngineType.Diesel)
        {
            FuelCapacity = fuelCapacity;
            CurrentFuel = currentFuel;
        }
        public bool Refuel(double fuel)
        {
            if (CurrentFuel < FuelCapacity)
            {
                CurrentFuel += fuel;
                return true;
            }
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using HW07.Enums;

namespace HW07
{
    public class ElectricCar : Car
    {
        public int BatteryCapacity { get; set; }
        public double BatteryUsage { get; set; }
        public ElectricCar(int id,string brand, string model, int doors, int topspeed, int batteryCapacity, double batteryUsage) : base(id, brand, model, doors, topspeed, Consumption.Economic, EngineType.Electric)
        {
            BatteryCapacity = batteryCapacity;
            BatteryUsage = batteryUsage;
        }
        

    }
}

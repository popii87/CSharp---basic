using HW07.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HW07
{
    public class Car
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string  Model { get; set; }
        public int Doors  { get; set; }
        public int TopSpeed { get; set; }
        public Consumption Consumption { get; set; }
        public EngineType EngineType { get; set; }
        public string PrintInfo()
        {
            return $"{Brand} {Model}";
        }
        public Car(int id, string brand, string model, int doors, int topspeed, Consumption consumption, EngineType engineType)
        {
            Id = id;
            Brand = brand;
            Model = model;
            Doors = doors;
            TopSpeed = topspeed;
            Consumption = consumption;
            EngineType = engineType;
        }
        public double Drive(int distance)
        {
            if (distance <= 0)
            {
                return -1;
            }
                double result = distance * (double)Consumption / 10;
                return result;
        }
    }
}

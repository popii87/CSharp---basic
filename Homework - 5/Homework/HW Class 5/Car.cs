using System;
using System.Collections.Generic;
using System.Text;

namespace HW_Class_5
{
    class Car
    {
        public string Model { get; set; }
        public double Speed { get; set; }
        public Driver Driver { get; set; }
        public double CalculateSpeed()
        {
            double result = Speed* Driver.Skill;
            return result; 
        }
        public Car(string model, double speed)
        {
            Model = model;
            Speed = speed;
            
        }
    }
}

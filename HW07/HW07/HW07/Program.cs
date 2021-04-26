using System;
using System.Collections.Generic;
using HW07.Enums;

namespace HW07
{
    class Program
    {
        public static List<Car> Cars { get; set; }
        static void Main(string[] args)
        {
            ElectricCar tesla = new ElectricCar(123, "Tesla", "X", 4, 300, 50, 100);
            FuelCar myCar = new FuelCar(456, "Mercedes", "E320", 5, 250, 80, 80);
            while (true)
            {
                Console.WriteLine("Enter how many km you should drive:");
                int distance;
                bool isDistanceNum = int.TryParse(Console.ReadLine(), out distance);
                if (!isDistanceNum)
                {
                    Console.WriteLine("Wrong input put number!!!");
                    continue;
                }
                double roadTrip = myCar.Drive(distance);
                if (roadTrip == -1)
                {
                    Console.WriteLine("Error enter distance > 0 km");
                    continue;
                }


                if (roadTrip > myCar.CurrentFuel)
                {
                    Console.WriteLine("Dont have enough fuel to go there");
                    continue;
                }
                else
                {
                    Console.WriteLine($"You need {roadTrip}L to reach your destination and you will have {myCar.FuelCapacity - roadTrip}L left fuel in the tank");
                    
                }
                 double fuelAfterTrip = myCar.CurrentFuel -= roadTrip;
                Console.WriteLine("Do you want to refuel and go again? Y/N");
                string choice = Console.ReadLine();
                if (choice.ToUpper() == "Y")
                {
                    while (true)
                    {
                        Console.WriteLine("Enter how many litres you want: ");
                        double litres;
                        bool tankChoice = double.TryParse(Console.ReadLine(), out litres);
                        if (!tankChoice || litres <= 0)
                        {
                            Console.WriteLine("Error");
                            continue;
                        }
                        else
                        {
                            bool fullTank = myCar.Refuel(litres);
                            if (!fullTank)
                            {
                                Console.WriteLine("Your tank is full");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Tanking fuel...");
                                if (myCar.CurrentFuel > myCar.FuelCapacity)
                                {
                                    Console.WriteLine($"Your tank capacity is: { myCar.FuelCapacity}L, you can put max { myCar.FuelCapacity - fuelAfterTrip }l");
                                    myCar.CurrentFuel = fuelAfterTrip;
                                    continue;

                                }
                                else if (myCar.CurrentFuel == myCar.FuelCapacity)
                                {
                                    Console.WriteLine("Up to the limit you are ready to go");
                                    continue;
                                }
                                
                                break;
                            }
                            
                        }
                        
                    }
                }
                else if (choice.ToUpper() == "N")
                {
                   return;
                  
                }
                

            }
            
        }
       
    }
}

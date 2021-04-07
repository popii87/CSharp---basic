using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            while (true)
            {
                Console.WriteLine("Enter a number:");
                bool input = double.TryParse(Console.ReadLine(), out double number);
                if (input == true && number >= -99999999 && number <= 99999999)
                {
                    NumberStats(number);
                    Console.WriteLine("Do you want to try again? y/x");
                    string newInput = Console.ReadLine();
                    if (newInput == "y" || newInput == "Y")
                    {
                        continue;
                    }
                    else if (newInput == "x" || newInput == "X")
                    {
                        break;
                    }
                    else
                    {
                        while (true)
                        {
                            Console.WriteLine("Invalid input, please enter Y or X");
                            string validInput = Console.ReadLine();
                            if (validInput == "Y" || validInput == "y")
                            {
                                break;
                            }
                            else if (validInput == "X" || validInput == "x")
                            {
                                return;
                            }
                            else
                            {
                                continue;
                            }
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Wrong input, Please enter Number!!!");
                    continue;
                }
            }
            
            
            
        }

        public static void NumberStats(double num)
        {
            if (num > 0)
            {
                Console.WriteLine("Positive");
            }
            else if (num < 0)
            {
                Console.WriteLine("Negative");
            }
            else 
            {
                Console.WriteLine($"It is {num}");
            }
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            if (num % 1 == 0)
            {
                Console.WriteLine("Integer");
            }
            else
            {
                Console.WriteLine("Decimal");
            }
            
            
        }
        
        
    }
}

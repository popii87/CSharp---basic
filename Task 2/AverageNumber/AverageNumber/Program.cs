﻿using System;

namespace AverageNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number");
            int num4 = int.Parse(Console.ReadLine());
            int average = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine($"The average of {num1}, {num2}, {num3}, and {num4} is: {average} ");
            Console.ReadLine();

        }
    }
}

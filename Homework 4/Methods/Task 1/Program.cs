using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"You are {CalcAge(age)} days old");
        }
        public static int CalcAge(int age)
        {
            int ageInDays = age * 365;
            return ageInDays;
        }
    }
}

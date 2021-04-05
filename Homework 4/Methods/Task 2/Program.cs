using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minutes");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine(ConvertTime(min) + " seconds");
        }

        public static int ConvertTime(int minutes)
        {
            int minToSeconds = minutes * 60;
            return minToSeconds;
        }
    }
}

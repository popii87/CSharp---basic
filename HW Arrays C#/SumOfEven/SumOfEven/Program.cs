using System;

namespace SumOfEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            Console.WriteLine("Enter 6 numbers");
            string getInput = Console.ReadLine();
            bool checkInput = int.TryParse(getInput, out numbers[0]);
            string getInput2 = Console.ReadLine();
            bool checkInput2 = int.TryParse(getInput2, out numbers[1]);
            string getInput3 = Console.ReadLine();
            bool checkInput3 = int.TryParse(getInput3, out numbers[2]);
            string getInput4 = Console.ReadLine();
            bool checkInput4 = int.TryParse(getInput4, out numbers[3]);
            string getInput5 = Console.ReadLine();
            bool checkInput5 = int.TryParse(getInput5, out numbers[4]);
            string getInput6 = Console.ReadLine();
            bool checkInput6 = int.TryParse(getInput6, out numbers[5]);
            int result = 0;
            foreach (int num in numbers)
            {
                result += num;

            }
            Console.WriteLine($"The result is: {result}");

        }
    }
}

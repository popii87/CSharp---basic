using System;

namespace RealCulator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Pick mathematical operation: +, -, *, /");
            var operation = Console.ReadLine();
            int result;
            switch (operation)
            {
                case "+":
                    result = num1 + num2;
                    Console.Write("The result is: " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.Write("The result is: " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.Write("The result is: " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.Write("The result is: " + result);
                    break;
                default:
                    Console.WriteLine("Wrong input");
                    break;

            }
            Console.ReadLine();

        }
    }
}

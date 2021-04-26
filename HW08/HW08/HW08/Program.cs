using System;
using System.Collections.Generic;

namespace HW08
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            Queue<int> numbers2 = new Queue<int>();
            Stack<int> numbers3 = new Stack<int>();

            while (true)
            {
                Console.WriteLine("Input number");
                int num;
                bool isNum = int.TryParse(Console.ReadLine(), out num);
                if (!isNum)
                {
                    Console.WriteLine("Wrong input");
                    continue;
                }
                numbers.Add(num);
                numbers2.Enqueue(num);
                numbers3.Push(num);
                Console.WriteLine($"{num} added to the collection");
                Console.WriteLine("Do you want to add another Y/N");
                string anotherInput = Console.ReadLine();
                if (anotherInput.ToUpper() == "Y")
                {
                    continue;
                }
                else if (anotherInput.ToUpper() == "N")
                {
                    foreach (var number in numbers3)
                    {
                        Console.WriteLine(number);
                    }
                    return;
                }
                

            }
        }
    }
}

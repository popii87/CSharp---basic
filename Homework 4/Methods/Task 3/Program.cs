using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FootballPoints(3, 4, 2));
            Console.WriteLine(FootballPoints(5, 0, 2));
            Console.WriteLine(FootballPoints(0, 0, 1));
            Console.WriteLine("Enter number of wins");
            int win = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of draws");
            int draw = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of losses");
            int loss = int.Parse(Console.ReadLine());
            Console.WriteLine("Total: " + FootballPoints(win, draw, loss) + " points");
        }

        public static int FootballPoints(int w, int d, int l)
        {
            int result = w * 3 + d * 1 + l * 0;
            return result;
        }
    }
}

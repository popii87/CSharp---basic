using System;

namespace StudentGroup
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] studentsG1 = { "Zdravko", "Petko", "Stanko", "Branko", "Trajko" };
            string[] studentsG2 = { "Anja", "Sara", "Nevenka", "Stefanija", "Marko" };
            Console.WriteLine("Enter student group: (there are 1 and 2)");
            string getInput = Console.ReadLine();
            int numOfGroup;
            bool checkInput = int.TryParse(getInput, out numOfGroup);
            switch (numOfGroup)
            {
                case 1:
                    Console.WriteLine("The students in G1 are:");
                    foreach (string student in studentsG1)
                    {
                        
                        Console.WriteLine(student);
                    }
                    break;
                case 2:
                    Console.WriteLine("The students in G2 are:");
                    foreach (string student in studentsG2)
                    {

                        Console.WriteLine(student);
                    }
                    break;
            }
        }
    }
}

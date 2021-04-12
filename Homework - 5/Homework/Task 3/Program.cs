using System;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // ATM Aplication
                        Customers[] customers = new Customers[3];
            customers[0] = new Customers("Robert", "Dimov", "1234-1234-1234-1234", 0000, 10000);
            customers[1] = new Customers("Bob", "Bobsky", "2345-2345-2345-2345", 1111, 5000);
            customers[2] = new Customers("Petko", "Petkovski", "5678-5678-5678-5678", 2255, 2000);

            Console.WriteLine("Welcome to the ATM app" +
                              "\nPlease Enter your card number:");
            string cardNumber = Console.ReadLine();
            Console.WriteLine("Pin:");
            bool inputPin = int.TryParse(Console.ReadLine(), out int pin);

            foreach (var customer in customers)
            {
                if (cardNumber == customer.CardNumber && pin == customer.Pin)
                {
                    Console.WriteLine($"Welcome {customer.FirstName} {customer.LastName}");
                    Console.WriteLine("What would you like to do:");
                    Console.WriteLine("1) Check Balance" +
                                    "\n2) Cash Withdrawal" +
                                    "\n3) Cash Deposit");
                    string getValue = Console.ReadLine();
                    switch (getValue)
                    {
                        case "1":
                            Console.WriteLine($"Your Balance is: {customer.Balance}");
                            break;
                        case "2":
                            Console.WriteLine("Enter amount");
                            int getAmount = int.Parse(Console.ReadLine());
                            if (getAmount <= customer.Balance)
                            {
                                Console.WriteLine($"You withdrew {getAmount}$. You have { customer.Balance - getAmount }$ left on your account.");
                                Console.WriteLine("Thank you for using the ATM app.");
                                break;
                            }
                            else
                            {
                                Console.WriteLine($"Your Balance is: {customer.Balance}");
                                break;
                            }
                        case "3":
                            Console.WriteLine("Currently not working ");
                            break;
                    }
                             break;
                }
            }
            
            
        }
    }
}

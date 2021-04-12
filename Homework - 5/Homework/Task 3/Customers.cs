using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3
{
     public class Customers
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public int Pin { get; set; }
        public int Balance { get; set; }
        public Customers(string firstName, string lastName, string cardNumber, int pin, int balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNumber;
            Pin = pin;
            Balance = balance;
        }
    }
}

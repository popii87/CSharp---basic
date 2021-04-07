using System;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[3];
            users[0] = new User(2254, "Robert", "popi", new string[] {"mess1","mess2" });
            users[1] = new User(2256, "Marko", "mar", new string[] { "mess3", "mess4" });
            users[2] = new User(2258, "Sara", "sa", new string[] { "mess5", "mess6" });
            Console.WriteLine("Log In/ Register");
            string getInput = Console.ReadLine();
            switch (getInput)
            {
                case "Log In":
                    while (true)
                    {
                        Console.WriteLine("Enter your Username: ");
                        string getUser = Console.ReadLine();
                        Console.WriteLine("Enter your Password: ");
                        string getPass = Console.ReadLine();
                        foreach (var user in users)
                        {
                            if (getUser == user.Username && getPass == user.Password)
                            {
                                Console.WriteLine($"Welcome {user.Username}. Here are your messages:");
                                Console.WriteLine($"{user.Messages[0]}");
                                Console.WriteLine($"{user.Messages[1]}");
                                return;
                            }

                        }
                        Console.WriteLine("Wrong Username or Password");

                    }
                //break;
                case "Register":
                    while (true)
                    {
                        Console.WriteLine("Enter your Id:");
                        bool getIdInput = int.TryParse(Console.ReadLine(), out int getId);
                        Console.WriteLine("Enter your Username:");
                        string getUserInput = Console.ReadLine();
                        Console.WriteLine("Enter your Password:");
                        string getPassInput = Console.ReadLine();
                        foreach (var user in users)
                        {
                            if (getUserInput == user.Username)
                            {
                                Console.WriteLine($"There is already username {getUserInput}, try different one :(");
                                break;
                            }
                            else
                            {
                                Array.Resize(ref users, 4);
                                users[3] = new User(getId, getUserInput, getPassInput, new string[] { "mess7", "mess8" });
                                Console.WriteLine("Registration complete ! Users:");
                                foreach (var item in users)
                                {
                                    Console.WriteLine($"{item.Id} {item.Username}");
                                }
                               return;
                            }


                        }
                        
                        


                    }
                    
                    break;
            }
            
            
        }
    }
}

using System;

namespace HW_Class_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Car huyndai = new Car("Hyundai", 180);
            Car mazda = new Car("Mazda", 175);
            Car ferrari = new Car("Ferrari", 300);
            Car porsche = new Car("Porsche", 285);

            Driver bob = new Driver("Bob", 5);
            Driver greg = new Driver("Greg", 4);
            Driver jill = new Driver("Jill", 3);
            Driver anne = new Driver("Anne", 2);
            

            
            
            
            while (true)
            {
                Console.WriteLine($"Please select Car no.1: \n 1.{huyndai.Model}\n 2.{mazda.Model} \n 3.{ferrari.Model} \n 4.{porsche.Model}");
                int gettInputCar1 = int.Parse(Console.ReadLine());
                string firstCarModel ="";
                double firstcarSpeed = 0;
                switch (gettInputCar1)
                {
                    case 1:
                        firstCarModel = huyndai.Model;
                        firstcarSpeed = huyndai.Speed;
                        break;
                    case 2:
                        firstCarModel = mazda.Model;
                        firstcarSpeed = mazda.Speed;
                        break;
                    case 3:
                        firstCarModel = ferrari.Model;
                        firstcarSpeed = ferrari.Speed;
                        break;
                    case 4:
                        firstCarModel = porsche.Model;
                        firstcarSpeed = porsche.Speed;
                        break;
                }

                Console.WriteLine($"Please select Driver no.1: \n 1. {bob.Name}\n 2.{greg.Name}\n 3.{jill.Name}\n 4.{anne.Name}");
                int getInputDriver1 = int.Parse(Console.ReadLine());
                string firstrDriver = "";
                int firstDriverSkill = 0;
                switch (getInputDriver1)
                {
                    case 1:
                        firstrDriver = bob.Name;
                        firstDriverSkill = bob.Skill;
                        break;
                    case 2:
                        firstrDriver = greg.Name;
                        firstDriverSkill = greg.Skill;
                        break;
                    case 3:
                        firstrDriver = jill.Name;
                        firstDriverSkill = jill.Skill;
                        break;
                    case 4:
                        firstrDriver = anne.Name;
                        firstDriverSkill = anne.Skill;
                        break;
                }
                Car carNo1 = new Car(firstCarModel, firstcarSpeed);
                Driver firstDriver = new Driver(firstrDriver, firstDriverSkill);
                carNo1.Driver = firstDriver;

                string secondCar = "";
                double secondCarSpeed = 0;
                if (carNo1.Model == huyndai.Model)
                {
                    Console.WriteLine($"Please select Car no.2: \n 1.{mazda.Model}\n 2.{ferrari.Model} \n 3.{porsche.Model} \n ");
                    int getCar2 = int.Parse(Console.ReadLine());
                    switch (getCar2)
                    {
                        case 1:
                            secondCar = mazda.Model;
                            secondCarSpeed = mazda.Speed;
                            break;
                        case 2:
                            secondCar = ferrari.Model;
                            secondCarSpeed = ferrari.Speed;
                            break;
                        case 3:
                            secondCar = porsche.Model;
                            secondCarSpeed = porsche.Speed;
                            break;
                        
                    }

                    
                }
                if (carNo1.Model == mazda.Model)
                {
                    Console.WriteLine($"Please select Car no.2: \n 1.{huyndai.Model}\n 2.{ferrari.Model} \n 3.{porsche.Model} \n ");
                    int getCar2 = int.Parse(Console.ReadLine());
                    switch (getCar2)
                    {
                        case 1:
                            secondCar = huyndai.Model;
                            secondCarSpeed = huyndai.Speed;
                            break;
                        case 2:
                            secondCar = ferrari.Model;
                            secondCarSpeed = ferrari.Speed;
                            break;
                        case 3:
                            secondCar = porsche.Model;
                            secondCarSpeed = porsche.Speed;
                            break;

                    }


                }
                if (carNo1.Model == ferrari.Model)
                {
                    Console.WriteLine($"Please select Car no.2: \n 1.{huyndai.Model}\n 2.{mazda.Model} \n 3.{porsche.Model} \n ");
                    int getCar2 = int.Parse(Console.ReadLine());
                    switch (getCar2)
                    {
                        case 1:
                            secondCar = huyndai.Model;
                            secondCarSpeed = huyndai.Speed;
                            break;
                        case 2:
                            secondCar = mazda.Model;
                            secondCarSpeed = mazda.Speed;
                            break;
                        case 3:
                            secondCar = porsche.Model;
                            secondCarSpeed = porsche.Speed;
                            break;

                    }


                }
                if (carNo1.Model == porsche.Model)
                {
                    Console.WriteLine($"Please select Car no.2: \n 1.{huyndai.Model}\n 2.{mazda.Model} \n 3.{ferrari.Model} \n ");
                    int getCar2 = int.Parse(Console.ReadLine());
                    switch (getCar2)
                    {
                        case 1:
                            secondCar = huyndai.Model;
                            secondCarSpeed = huyndai.Speed;
                            break;
                        case 2:
                            secondCar = mazda.Model;
                            secondCarSpeed = mazda.Speed;
                            break;
                        case 3:
                            secondCar = ferrari.Model;
                            secondCarSpeed = ferrari.Speed;
                            break;

                    }


                }

                //Second Driver
                string secondDriver = "";
                int secondDriverSkill = 0;
                if (firstDriver.Name == bob.Name)
                {
                    Console.WriteLine($"Please select Driver no.2:\n 1.{greg.Name} \n 2.{jill.Name} \n 3.{anne.Name}  ");
                    int getInputDriver2 = int.Parse(Console.ReadLine());
                    switch (getInputDriver2)
                    {
                        case 1:
                            secondDriver = greg.Name;
                            secondDriverSkill = greg.Skill;
                            break;
                        case 2:
                            secondDriver = jill.Name;
                            secondDriverSkill = jill.Skill;
                            break;
                        case 3:
                            secondDriver = anne.Name;
                            secondDriverSkill = anne.Skill;
                            break;

                    }
                }
                if (firstDriver.Name == greg.Name)
                {
                    Console.WriteLine($"Please select Driver no.2:\n 1. {bob.Name} \n2. {jill.Name} \n3. {anne.Name} \n ");
                    int getInputDriver2 = int.Parse(Console.ReadLine());
                    switch (getInputDriver2)
                    {
                        case 1:
                            secondDriver = bob.Name;
                            secondDriverSkill = bob.Skill;
                            break;
                        case 2:
                            secondDriver = jill.Name;
                            secondDriverSkill = jill.Skill;
                            break;
                        case 3:
                            secondDriver = anne.Name;
                            secondDriverSkill = anne.Skill;
                            break;

                    }
                }
                if (firstDriver.Name == jill.Name)
                {
                    Console.WriteLine($"Please select Driver no.2:\n 1. {bob.Name} \n2. {greg.Name} \n3. {anne.Name} \n ");
                    int getInputDriver2 = int.Parse(Console.ReadLine());
                    switch (getInputDriver2)
                    {
                        case 1:
                            secondDriver = bob.Name;
                            secondDriverSkill = bob.Skill;
                            break;
                        case 2:
                            secondDriver = greg.Name;
                            secondDriverSkill = greg.Skill;
                            break;
                        case 3:
                            secondDriver = anne.Name;
                            secondDriverSkill = anne.Skill;
                            break;

                    }
                }
                if (firstDriver.Name == anne.Name)
                {
                    Console.WriteLine($"Please select Driver no.2:\n 1. {bob.Name} \n2. {greg.Name} \n3. {jill.Name} \n ");
                    int getInputDriver2 = int.Parse(Console.ReadLine());
                    switch (getInputDriver2)
                    {
                        case 1:
                            secondDriver = bob.Name;
                            secondDriverSkill = bob.Skill;
                            break;
                        case 2:
                            secondDriver = greg.Name;
                            secondDriverSkill = greg.Skill;
                            break;
                        case 3:
                            secondDriver = jill.Name;
                            secondDriverSkill = jill.Skill;
                            break;

                    }
                }
                Car carNo2 = new Car(secondCar, secondCarSpeed);
                Driver driver2 = new Driver(secondDriver, secondDriverSkill);
                carNo2.Driver = driver2;
                RaceCars(carNo1, carNo2);
                Console.WriteLine("Do you want to race again type: \nyes \nno");
                string raceInput = Console.ReadLine();
                if (raceInput == "yes")
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
            

        }

        public static void RaceCars(Car firstCar, Car secondCar)
        {
            if (firstCar.CalculateSpeed() > secondCar.CalculateSpeed())
            {
                Console.WriteLine("Car no.1 was faster.");
            }
            else
            {
                Console.WriteLine("Car no.2 was faster");
            }
        }


        
    }

}

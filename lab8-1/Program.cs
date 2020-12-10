using System;

namespace lb
{
    class Program
    {

        static void FindCar(int InputNumber)
        {
            Garage garage = new Garage();
            Console.WriteLine("How to find this car?\n1. By name\n2. By color\n3. By speed\n4. By year\n5. Exit\nWrite the number (e.g 2)");
            InputNumber = 5;
            do
            {
                Console.Write("--> ");
                InputNumber = int.Parse(Console.ReadLine());
            } while (InputNumber < 0 || InputNumber > 6);



            string Name, Color;
            int Speed, Year;
            if (InputNumber == 1)
            {
                Console.Write("--> ");
                Name = Console.ReadLine();
                garage.ChooseCarByName(Name);
            }

            if (InputNumber == 2)
            {
                Console.Write("--> ");
                Color = Console.ReadLine();
                garage.ChooseCarByColor(Color);
            }

            if (InputNumber == 3)
            {
                Console.Write("--> ");
                Speed = int.Parse(Console.ReadLine());
                garage.ChooseCarBySpeed(Speed);
            }

            if (InputNumber == 4)
            {
                Console.Write("--> ");
                Year = int.Parse(Console.ReadLine());
                garage.ChooseCarByYear(Year);
            }

        }

        static void AddCar()
        {
            Garage garage = new Garage();
            string Name, Color;
            int Speed, Year, NumberOfCars = 3;
            

            Console.Write("Enter the name of the car --> ");
            Name = Console.ReadLine();
            Console.Write("Enter car color --> ");
            Color = Console.ReadLine();
            Console.Write("Enter machine speed --> ");
            Speed = int.Parse(Console.ReadLine());
            Console.Write("Enter the year of manufacture of the machine --> ");
            Year = int.Parse(Console.ReadLine());

            NumberOfCars++;
        
            Vehicle car4 = new Vehicle(Name, Color, Speed, Year);
            garage.AddCar(car4);
        }

        static void ShowAllCars()
        {
            Garage garage = new Garage();
            garage.GetListOfCars();
        }

        static void DeleteCar()
        {
            string name;

            Garage garage = new Garage();
            Console.Write("--> ");
            name = Console.ReadLine();
            Vehicle car3 = new Vehicle("Mustang", "red", 300, 2020);
            garage.DeleteCar(car3);
        }



        static void Main(string[] args)
        {
            Vehicle car1 = new Vehicle("Porsche", "red", 260, 2019);
            Vehicle car2 = new Vehicle("Mitsubishi", "blue", 250, 2018);
            Vehicle car3 = new Vehicle("Mustang", "red", 300, 2020);


            Garage garage = new Garage();
            garage.AddCar(car1);
            garage.AddCar(car2);
            garage.AddCar(car3);

            garage.ChooseCarBySpeed(250);

            int InputNumber = 5;
            do
            {
                Console.WriteLine("What do do?\n1. Add car\n2. Find car\n3. Show all cars\n4. Delete car\n5. Close the program\nWrite the number (e.g 2)");
                do
                {
                    Console.Write("--> ");
                    InputNumber = int.Parse(Console.ReadLine());
                } while (InputNumber < 0 || InputNumber > 6);
                
                if(InputNumber == 1)
                {
                    AddCar();
                }

                if (InputNumber == 2)
                {
                    FindCar(InputNumber);
                }

                if (InputNumber == 3)
                {
                    ShowAllCars();
                }

                if (InputNumber == 4)
                {
                    DeleteCar();
                }

                

            } while (InputNumber != 5);
   
            Console.ReadKey();
        }
    }
}
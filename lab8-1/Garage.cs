using System;
using System.Collections.Generic;

namespace lb
{
    class Garage
    {
        List<Vehicle> cars = new List<Vehicle>();

        public void AddCar(Vehicle Obj)
        {
            cars.Add(Obj);
        }

        public void DeleteCar(Vehicle Obj)
        {
            cars.Remove(Obj);
        }

        public void GetListOfCars()
        {
            foreach (Vehicle i in cars)
            {
                i.GetVehicle();
            }
            Console.WriteLine();
        }

        public void ChooseCarByName(string name)
        {
            Console.WriteLine("Chosen by Sheik by name: ");
            Console.WriteLine(name);

            foreach (Vehicle i in cars)
            {
                if (i.GetName() == name)
                {
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }

        public void ChooseCarByColor(string color)
        {
            Console.WriteLine("Chosen by Sheik by color:");
            Console.WriteLine(color);

            foreach (Vehicle i in cars)
            {
                if (i.GetColor() == color)
                {
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }

        public void ChooseCarBySpeed(int speed)
        {
            Console.WriteLine("Chosen by Sheik by speed:");
            
            foreach (Vehicle i in cars)
            {
                if (i.GetSpeed() == speed)
                {
                    Console.WriteLine(speed);
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }

        public void ChooseCarByYear(int year)
        {
            Console.WriteLine("Chosen by Sheik by year of manufacture:");
            foreach (Vehicle i in cars)
            {
                if (i.GetYearOfManufacture() == year)
                {
                    i.GetVehicle();
                }
            }
            Console.WriteLine();
        }
    }
}
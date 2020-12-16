using System;
using System.Collections.Generic;

namespace ConsoleApp6
{
    class Cars
    {
        string colors;
        int year;
        double cost;
        float speed;

        static List<Cars> listOfCars = new List<Cars>();
        public Cars(string colors, int year, double cost, float speed)
        {
            this.colors = colors;
            this.year = year;
            this.cost = cost;
            this.speed = speed;
         
        }
        static public void AddCar(Cars Obj)
        {
            listOfCars.Add(Obj);
        }
        public void GetCarsInfo()
        {
            Console.WriteLine("\nColors: " + colors + "\nYear of issue: " + year + "\nCost: " + cost + "\ncost: " + speed);
        }
        static public void ChooseCar(string colors, int year, double cost, float speed)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.colors == colors && i.year == year && i.cost == cost && i.speed == speed)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(string colors, int year, double cost)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.colors == colors && i.year == year && i.cost == cost)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(int year, double cost, float speed)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.year == year && i.cost == cost && i.speed == speed)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(string colors, double cost, float speed)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.colors == colors && i.cost == cost && i.speed == speed)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(string colors, int year, float speed)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.colors == colors && i.year == year && i.speed == speed)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(string colors, int year)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.colors == colors && i.year == year)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(double cost, float speed)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.cost == cost && i.speed == speed)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(string colors, double cost)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.colors == colors && i.cost == cost)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(string colors, float speed)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.colors == colors && i.speed == speed)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(int year, double cost)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.year == year && i.cost == cost)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(int year, float speed)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.year == year && i.speed == speed)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(string colors)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.colors == colors)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(int year)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.year == year)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(double cost)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.cost == cost)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
        static public void ChooseCar(float speed)
        {
            Console.WriteLine("\nResult: ");

            bool notFound = true;
            foreach (Cars i in listOfCars)
            {
                if (i.speed == speed)
                {
                    i.GetCarsInfo();
                    notFound = false;
                }
            }
            if (notFound) Console.WriteLine("\n\tNot Found");
        }
    }
}
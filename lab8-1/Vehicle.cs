using System;

namespace lb
{
    class Vehicle
    {
        string name, color;
        int speed, yearOfManufacture;

        public Vehicle(string name, string color, int speed, int yearOfManufacture)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            this.yearOfManufacture = yearOfManufacture;
        }

        public void GetVehicle()
        {
            Console.WriteLine("Name: " + name + "\tColor: " + color + "\tSpeed: " + speed + "\tYear of manufacture: " + yearOfManufacture);
        }
        public string GetName()
        {
            return name;
        }
        public string GetColor()
        {
            return color;
        }
        public int GetSpeed()
        {
            return speed;
        }
        public int GetYearOfManufacture()
        {
            return yearOfManufacture;
        }
    }
}
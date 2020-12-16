using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            Cars Ferrari = new Cars("Red White", 1996, 27000, 300);
            Cars Fiat = new Cars("Blue Gray", 2005, 34000, 270);
            Cars Lamborghini = new Cars("Brown Red", 2000, 30000, 210);
            Cars Maserati = new Cars("Yellow Red Blue", 2010, 48000, 320);
            Cars AlfaRomeo = new Cars("Black White Grey", 2001, 29000, 290);

            Cars.AddCar(Ferrari);
            Cars.AddCar(Fiat);
            Cars.AddCar(Lamborghini);
            Cars.AddCar(Maserati);
            Cars.AddCar(AlfaRomeo);

            Cars.ChooseCar("Red", 1996, 27000, 300);
            Cars.ChooseCar("Brown", 2000, 30000);
            Cars.ChooseCar(2010, 48000, 320);
            Cars.ChooseCar("Yellow", 48000, 320);
            Cars.ChooseCar("Gray", 2005, 270);
            Cars.ChooseCar("Blue", 2005);
            Cars.ChooseCar(48000, 320);
            Cars.ChooseCar("White", 29000);
            Cars.ChooseCar("Red", 320);
            Cars.ChooseCar(1996, 27000);
            Cars.ChooseCar(29000, 290);
            Cars.ChooseCar("Grey");
            Cars.ChooseCar(2010);
            Cars.ChooseCar(29000);
            Cars.ChooseCar(210);


            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Triangle : Shape
    {
        Random random = new Random();

        double size2;

        public Triangle(string name)
        {

            this.name = name;
            size = random.Next(1, 100);
            size2 = Math.Sqrt(2 * size * size);
            color = (ConsoleColor)random.Next(16);
            numberOfApexes = 3;
        }

        public Triangle(string name, int size, int size2)
        {
            this.name = name;
            this.size = size;
            this.size2 = size2;
            color = (ConsoleColor)new Random().Next(16);
            numberOfApexes = 3;
        }

        public Triangle(string name, int size, int size2, ConsoleColor color)
        {
            this.name = name;
            this.size = size;
            this.size2 = size2;
            this.color = color;
            numberOfApexes = 3;
        }

        public override void Area()
        {
            double temp = size * size - (size2 * size2) / 4;

            area = (size2 * temp) / 2;
        }
        public override void Length()
        {
            length = 2 * size + size2;
        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
            if (color == ConsoleColor.White) Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Name: {0}\tSize 1: {1}\tSize 2: {2}\tArea: {3}\tLength: {4}\tAmount of apexes: {5}", name, size, size2, area, length, numberOfApexes);

            Console.ResetColor();
        }
    }
}

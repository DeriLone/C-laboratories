using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Square : Shape
    {
        Random random = new Random();

        public Square(string name)
        {

            this.name = name;
            size = random.Next(1, 100);
            color = (ConsoleColor)random.Next(16);
            numberOfApexes = 4;
        }

        public Square(string name, int size)
        {
            this.name = name;
            this.size = size;
            color = (ConsoleColor)new Random().Next(16);
            numberOfApexes = 4;
        }

        public Square(string name, int size, ConsoleColor color)
        {
            this.name = name;
            this.size = size;
            this.color = color;
            numberOfApexes = 4;
        }

        public override void Area()
        {
            area = size * size;
        }
        public override void Length()
        {
            length = numberOfApexes * size;
        }
        public override void Draw()
        {
            Console.ForegroundColor = color;
            if (color == ConsoleColor.Black) Console.BackgroundColor = ConsoleColor.White;
            if (color == ConsoleColor.White) Console.BackgroundColor = ConsoleColor.Black;

            Console.WriteLine("Name: {0}\tSize: {1}\tArea: {2}\tLength: {3}\tAmount of apexes: {4}", name, size, area, length, numberOfApexes);

            Console.ResetColor();
        }

    }
}

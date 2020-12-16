using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Lab9
{
    interface IDraw
    {
        void Draw();
    }

    class Painter
    {
        public static void Draw(IDraw Obj)
        {
            Obj.Draw();
        }
    }

    abstract class Shape : IDraw
    {
        public ConsoleColor color;
        public int numberOfApexes { get; protected set; }
        public string name { get; protected set; }
        public int size;
        public double area;
        public double length;

        public abstract void Area();
        public abstract void Length();
        public abstract void Draw();

    }



    class Program
    {
        static void Main(string[] args)
        {
            Square sq = new Square("square");
            Thread.Sleep(200);

            Circle cr = new Circle("circle");
            Thread.Sleep(200);

            Triangle tr = new Triangle("triangle");
            Thread.Sleep(200);


            sq.Area();
            sq.Length();
            cr.Area();
            cr.Length();
            tr.Area();
            tr.Length();


            Picture picture = new Picture(3);
            picture.AddShape(sq);
            picture.AddShape(cr);
            picture.AddShape(tr);

            Console.WriteLine("Length of list : {0}", picture.lengthOfList);

            Console.WriteLine("Painter.Draw(sq)");
            Painter.Draw(sq);

            Console.WriteLine("picture:");
            picture.Draw();
            picture.DeleteShape("square");

            Console.WriteLine("picture[0].name : {0}", picture[0].name);

            Console.ReadLine();
        }
    }
}
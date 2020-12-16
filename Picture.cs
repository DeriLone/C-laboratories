using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    class Picture
    {
        public List<Shape> shapes;

        public int lengthOfList
        {
            get
            {
                return shapes.Count();
            }
        }

        public Picture()
        {
            shapes = new List<Shape>();
        }

        public Picture(int lengthOfList)
        {
            shapes = new List<Shape>(lengthOfList);
        }

        public void AddShape(Shape Obj)
        {
            shapes.Add(Obj);
        }
        public void DeleteShape(string name)
        {
            shapes.RemoveAll(i => i.name == name);
        }

        public void DeleteShape(int apexes)
        {
            shapes.RemoveAll(i => i.numberOfApexes == apexes);
        }
        public void DeleteShape(double area)
        {
            shapes.RemoveAll(i => i.area == area);
        }
        public void Draw()
        {
            foreach (Shape i in shapes)
                i.Draw();
        }

        public Shape this[int index]
        {
            get
            {
                return shapes[index];
            }
        }
    }
}

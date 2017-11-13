using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_3
{
    class ShapeDescriptor
    {
        public readonly Point a;
        private readonly Point b;
        private readonly Point c;
        private readonly Point d;
        public string ShapeType;// { get; set; }

        public ShapeDescriptor(int x1, int y1)
        {
            a = new Point(x1, y1);
            ShapeType = "Point";
        }
        public ShapeDescriptor(int x1, int y1, int x2, int y2)
            : this(x1, y1)
        {
            b = new Point(x2, y2);
            ShapeType = "Line";
        }
        public ShapeDescriptor(int x1, int y1, int x2, int y2, int x3, int y3)
            : this(x1, y1, x2, y2)
        {
            c = new Point(x3, y3);
            ShapeType = "Triangle";
        }
        public ShapeDescriptor(int x1, int y1, int x2, int y2, int x3, int y3, int x4, int y4)
            : this(x1, y1, x2, y2, x3, y3)
        {
            d = new Point(x4, y4);
            ShapeType = "Quadrilateral";
        }
    }

    class Point
    {
        public readonly int _x = 0;
        private readonly int _y;

        public Point(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ShapeDescriptor obj1 = new ShapeDescriptor(1, 1);
            ShapeDescriptor obj2 = new ShapeDescriptor(1,1,2,2);
            ShapeDescriptor obj3 = new ShapeDescriptor(1, 1, 2, 2, 3, 3, 3, 3);
            Console.WriteLine(obj1.ShapeType);
            Console.WriteLine(obj2.ShapeType);
            Console.WriteLine(obj3.ShapeType);
            Console.WriteLine(obj1.a._x);
            //obj1.a._x = 1;
            Console.ReadKey();
        }
    }
}

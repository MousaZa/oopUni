using System;

namespace oopUni
{

    
    internal class InfoClass {
        public static void printInfo(Point p)
        {
            p.printCoordinates();
        }
    }
    internal abstract class Point
    {
        public int _x { set; get; }
        public int _y { set; get; }

        public void printInfo()
        {
            Console.WriteLine("This is a POINT!");
        }

        public abstract void printCoordinates();
    }

    internal class Point2D : Point
    {
        public Point2D()
        {
            _x = 0;
            _y = 0;
        }
        public Point2D(int x , int y)
        {
            _x = x;
            _y = y;
        }

        public override void printCoordinates()
        {
            Console.WriteLine("The coordinates of the point is ("+_x+","+_y+").");
        }
    }
    
    internal class Point3D : Point
    {
        public int _z { get; set; }
        public Point3D()
        {
            _x = 0;
            _y = 0;
            _z = 0;
        }
        public Point3D(int x , int y,int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public override void printCoordinates()
        {
            Console.WriteLine("The coordinates of the point is ("+_x+","+_y+","+_z+").");
        }
    }
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            Point2D point1 = new Point2D();
            point1.printCoordinates();

            Point2D point2 = new Point2D(3,4);
            point2.printCoordinates();

            Point3D point3 = new Point3D(3,4,5);
            point3.printCoordinates();
            
            InfoClass.printInfo(point1);
            InfoClass.printInfo(point2);
            InfoClass.printInfo(point3);
        }
    }
}
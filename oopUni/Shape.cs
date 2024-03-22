using System;

namespace oopUni
{
    public class Shape
    {
        public Point2D Coordinates { set; get; } // = new Point2D() ; this one will use more resources

        public Shape()
        {
            Coordinates = new Point2D() ;
        }

        public Shape(Point2D coordinates)
        {
            Coordinates = coordinates ;
        }

        public virtual void DrawShape()
        {
            Console.WriteLine("Drawing a shape at ( " + Coordinates.CoordinatesX + " , " + Coordinates.CoordinatesY + " ).");
        }

        public void PrintInformation()
        {
            Console.WriteLine("this is a SHAPE !");
        }

        ~Shape()
        {
            Console.WriteLine("Shape deleted !");
        }
    }
}
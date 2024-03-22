using System;

namespace oopUni
{
    public class Circle : Shape
    {
        public int Radius { set; get; }

        public Circle()
        {
            
        }

        public Circle(Point2D coordinates , int radius) : base(coordinates)
        {
            Radius = radius;
        }

        public void PrintArea()
        {
            Console.WriteLine("Area of the circle is " + Math.PI * Radius * Radius);
        }
        public override void DrawShape()
        {
            Console.WriteLine("Drawing a circle at ( " + Coordinates.CoordinatesX + " , " + Coordinates.CoordinatesY + " ) with radius : " + Radius );
        }
        public new void PrintInformation()
        {
            Console.WriteLine("this is a CIRCLE !");
        }
        
        ~Circle()
        {
            Console.WriteLine("Circle deleted !");
        }
    }
}

using System;
namespace oopUni

{
    

    internal class Program
    {
        public static void Main(string[] args)
        {
            // Point2D point = new Point2D(3 , 4);
            // point.ConvertToPolar();
            Shape shape = new Shape(new Point2D(3,4));
            // shape.DrawShape();
            Square square = new Square(new Point2D(3, 4));
            // square.DrawShape();
            Circle circle = new Circle(new Point2D(3, 4), 5);
            // circle.DrawShape();
            Shape[] shapes =
            {
                shape, square, circle
            };

            foreach (var sh in shapes)
            {
                sh.DrawShape();
                sh.PrintInformation();
                
                if (sh is Circle)
                    ((Circle)sh).PrintArea();
                Line.DrawLine('x' , 40);
            }
        }
    }
}
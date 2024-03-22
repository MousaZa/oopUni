using System ;
namespace oopUni
{
    public class Square : Shape
    {
        public Square()
        {
            Coordinates = new Point2D() ;
        }

        public Square(Point2D coordinates) : base(coordinates)
        {
            Coordinates = coordinates ;
        }

        public override void DrawShape()
        {
            Console.WriteLine("Drawing a square at ( " + Coordinates.CoordinatesX + " , " + Coordinates.CoordinatesY + " ).");
        }

        public new void PrintInformation()
        {
            Console.WriteLine("this is a SQUARE !");
        }

        ~Square()
        {
            Console.WriteLine("Square deleted !");
        }   
    }
}
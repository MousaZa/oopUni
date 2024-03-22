using System;

namespace oopUni
{
    public class Point2D
    {
        public int CoordinatesX { set; get; } = 0;
        public int CoordinatesY { set; get; } = 0;

        public Point2D()
        {
            
        }

        public Point2D(int coordinatesx,int coordinatesy)
        {
            CoordinatesX = coordinatesx;
            CoordinatesY = coordinatesy;
        }

        public void ConvertToPolar()
        {
            double r = Math.Sqrt( CoordinatesX * CoordinatesX + CoordinatesY * CoordinatesY ) ;
            double theta = (180 / Math.PI) * Math.Atan((double) CoordinatesY / CoordinatesX );
            Console.WriteLine("Polar Coordinates of ( " + CoordinatesX + " , "+ CoordinatesY + " ) is ( " + r + " , " + String.Format("{0:0.00}\u00B0", theta) + " ).");
        }       
        
        ~Point2D()
        {
            Console.WriteLine("Point deleted !");
        }
    }
}

using System;
namespace oopUni

{
    internal class Program
    {
        public enum color
        {
            RED,
            GREEN,
            BLUE
        }
        public static void Main(string[] args)
        {
            
            color c1 = color.BLUE;
            if (c1 == color.BLUE)
                Console.WriteLine("The color is BLUE");
            
        }
    }
}